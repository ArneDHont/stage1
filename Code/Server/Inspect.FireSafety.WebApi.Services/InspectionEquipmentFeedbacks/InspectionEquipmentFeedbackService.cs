using Inspect.FireSafety.Business.EquipmentFeedbacks;
using Inspect.FireSafety.Business.FeedbackTypes;
using Inspect.FireSafety.Shared;
using Inspect.FireSafety.WebApi.FeedbackTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Inspect.FireSafety.WebApi.InspectionEquipmentFeedbacks;
using AutoMapper;
using Inspect.Framework.Hypermedia;
using Inspect.WebApi;
using System.IO;

namespace Inspect.FireSafety.WebApi.EquipmentFeedbacks
{
    [RoutePrefix("fire-safety/inspectionequipmentfeedback")]
    public class InspectionEquipmentFeedbackService : HypermediaApiController
    {
        private IInspectionEquipmentFeedbackBusinessComponent businessComponent;
        

        public InspectionEquipmentFeedbackService()
        {
            this.IncludeHypermediaForEquipmentFeedbackCollectionRepresentation();
            this.IncludeHypermediaForEquipmentFeedbackRepresentation();
        }
        public InspectionEquipmentFeedbackService(IInspectionEquipmentFeedbackBusinessComponent businessComponent) : this()
        {
            this.businessComponent = businessComponent;
        }

        public IInspectionEquipmentFeedbackBusinessComponent BusinessComponent
        {
            get
            {
                return businessComponent ?? (businessComponent = new InspectionEquipmentFeedbackBusinessComponent());
            }
            set
            {
                businessComponent = value;
            }
        }
        [HttpGet]
        [Route("", Name = nameof(EquipmentFeedbackCollectionGet))]
        public IHttpActionResult EquipmentFeedbackCollectionGet([FromUri]InspectionEquipmentFeedbackCollectionParameters parameters)
        {
            int totalCount = BusinessComponent.Count(new InspectionEquipmentFeedbackCollectionParametersSpecification(parameters));
            IEnumerable<InspectionEquipmentFeedback> EquipmentFeedbackFromDataAccess = BusinessComponent.Get(new InspectionEquipmentFeedbackCollectionParametersQuery(parameters));
            return Ok<InspectionEquipmentFeedbackRepresentation>(EquipmentFeedbackFromDataAccess, totalCount, parameters?.PageNumber, parameters?.PageSize);
        }

        [HttpGet]
        [Route("{id}", Name = nameof(EquipmentFeedbacksGetById))]
        public IHttpActionResult EquipmentFeedbacksGetById(int id, [FromUri]InspectionEquipmentFeedbackParameters parameters)
        {
            var equipmentFeedbackFromDataAccess = BusinessComponent.SingleOrDefault(new InspectionEquipmentFeedbackParametersQuery(id, parameters));
            if (equipmentFeedbackFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<InspectionEquipmentFeedbackRepresentation>(equipmentFeedbackFromDataAccess);
        }

        [HttpPost]
        [Route("", Name = nameof(EquipmentFeedbacksPostAdd))]
        public IHttpActionResult EquipmentFeedbacksPostAdd([FromBody] InspectionEquipmentFeedbackRepresentationForCreation entry)
        {            
            var entryFordb = Mapper.Map<InspectionEquipmentFeedbackRepresentationForCreation, InspectionEquipmentFeedback>(entry);
            BusinessComponent.Create(entryFordb);
            CreatedRepresentation result = new CreatedRepresentation(Url.Route(nameof(EquipmentFeedbacksGetById), new { id = entryFordb.InspectionEquipmentFeedbackId }));
            result.Links.Add(HypermediaLinks.Attachment , new Link(Url.Route(nameof(EquipmentFeedbackAttachmentPostAdd), new { id = entryFordb.InspectionEquipmentFeedbackId })));
            return CreatedAtRoute(nameof(EquipmentFeedbacksGetById), new { id = entryFordb.InspectionEquipmentFeedbackId }, result);
        }
        [HttpPost]
        [Route("update/{id}", Name = nameof(EquipmentFeedbacksUpdate))]
        public IHttpActionResult EquipmentFeedbacksUpdate(int id,[FromBody] InspectionEquipmentFeedbackRepresentationForCreation entry)
        {
            var equipmentFeedbackFromDataAccess = BusinessComponent.SingleOrDefault(new InspectionEquipmentFeedbackParametersQuery(id));
            if (equipmentFeedbackFromDataAccess == null)
            {
                return NotFound();
            }
            equipmentFeedbackFromDataAccess.EquipmentId = entry.EquipmentId;
            equipmentFeedbackFromDataAccess.EquipmentLocationDescription = entry.EquipmentLocationDescription;
            equipmentFeedbackFromDataAccess.EquipmentLocationName = entry.EquipmentLocationName;
            equipmentFeedbackFromDataAccess.FeedbackTypeId = entry.FeedbackTypeId;
            equipmentFeedbackFromDataAccess.OperatorId = entry.OperatorId;
            equipmentFeedbackFromDataAccess.Remark= entry.Remark;
            equipmentFeedbackFromDataAccess.Status = entry.Status;
            equipmentFeedbackFromDataAccess.TimeCompleted = entry.TimeCompleted;
            equipmentFeedbackFromDataAccess.Vera = entry.Vera;
            equipmentFeedbackFromDataAccess.Weight = entry.Weight;

            BusinessComponent.Update(equipmentFeedbackFromDataAccess);

            CreatedRepresentation result = new CreatedRepresentation(Url.Route(nameof(EquipmentFeedbacksGetById), new { id = equipmentFeedbackFromDataAccess.InspectionEquipmentFeedbackId }));
            result.Links.Add(HypermediaLinks.Attachment, new Link(Url.Route(nameof(EquipmentFeedbackAttachmentPostAdd), new { id = equipmentFeedbackFromDataAccess.InspectionEquipmentFeedbackId })));
            return CreatedAtRoute(nameof(EquipmentFeedbacksGetById), new { id = equipmentFeedbackFromDataAccess.InspectionEquipmentFeedbackId }, result);
        }

        [HttpPost]
        [Route("{id}/attachments", Name = nameof(EquipmentFeedbackAttachmentPostAdd))]
        public IHttpActionResult EquipmentFeedbackAttachmentPostAdd(int id ,[FromBody] Upload<InspectionEquipmentFeedbackAttachmentRepresentationForCreation> upload, [FromUri]InspectionEquipmentFeedbackParameters parameters)
        {
            var metadata = Mapper.Map<InspectionEquipmentFeedbackAttachmentRepresentationForCreation, Shared.InspectionEquipmentFeedbackAttachment>(upload.Metadata);
            using (MemoryStream ms = new MemoryStream())
            {
                upload.InputStream.CopyTo(ms);
                metadata.Binary = new AttachmentBinary() { Data = ms.ToArray()};
                
                var equipmentFeedbackFromDataAccess = BusinessComponent.SingleOrDefault(new InspectionEquipmentFeedbackParametersQuery(id,parameters));
                equipmentFeedbackFromDataAccess.Attachments.Add(metadata);
                BusinessComponent.Update(equipmentFeedbackFromDataAccess);
                CreatedRepresentation result = new CreatedRepresentation(Url.Route(nameof(EquipmentFeedbacksAttachmentGetById), new { id = equipmentFeedbackFromDataAccess.InspectionEquipmentFeedbackId, attachmentId = metadata.AttachmentId  }));
                return CreatedAtRoute(nameof(EquipmentFeedbacksGetById), new { id = equipmentFeedbackFromDataAccess.InspectionEquipmentFeedbackId, attachmentId = metadata.AttachmentId }, result);
            }
        }
            
        

        [HttpGet]
        [Route("{id}/attachments/{attachmentId}", Name = nameof(EquipmentFeedbacksAttachmentGetById))]
        public IHttpActionResult EquipmentFeedbacksAttachmentGetById(int attachmentId, [FromUri]InspectionEquipmentFeedbackParameters parameters)
        {
            var equipmentFeedbackAttachmentFromDataAccess = BusinessComponent.SingleOrDefault(new InspectionEquipmentFeedbackAttachmentParametersQuery(attachmentId, parameters));
            if (equipmentFeedbackAttachmentFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<InspectionEquipmentFeedbackRepresentation>(equipmentFeedbackAttachmentFromDataAccess);
        }
    }
}
