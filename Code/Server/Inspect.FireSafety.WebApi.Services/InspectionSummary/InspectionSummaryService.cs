using Inspect.FireSafety.Business.InspectionSummary;
using Inspect.FireSafety.Business.InspectionSummary.Mail;
using Inspect.FireSafety.WebApi.Contracts.InspectionSummary;
using Inspect.Framework.Business;
using Inspect.Framework.Hypermedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Inspect.FireSafety.WebApi.InspectionSummary
{
    [RoutePrefix("fire-safety/inspectionsummary")]
    public class InspectionSummaryService: HypermediaApiController
    {

        private IInspectionSummaryBusinessComponent businessComponent;


        public InspectionSummaryService()
        {
            
        }
        public InspectionSummaryService(IInspectionSummaryBusinessComponent businessComponent) : this()
        {
            this.businessComponent = businessComponent;
        }

        public IInspectionSummaryBusinessComponent BusinessComponent
        {
            get
            {
                return businessComponent ?? (businessComponent = new InspectionSummaryBusinessComponent());
            }
            set
            {
                businessComponent = value;
            }
        }

        [HttpGet]
        [Route("{id}", Name = nameof(InspectionSummaryGetById))]
        public IHttpActionResult InspectionSummaryGetById(int id)
        {
            var inspectionSummaryFromDataAccess = BusinessComponent.SingleOrDefault(new InspectionSummaryParametersQuery(id));
            if (inspectionSummaryFromDataAccess == null)
            {
                return NotFound();
            }
            return Ok<InspectionSummaryRepresentation>(inspectionSummaryFromDataAccess);
        }

        [HttpPost]
        [Route("", Name = nameof(InspectionSummaryPostAdd))]
        public IHttpActionResult InspectionSummaryPostAdd([FromBody] InspectionSummaryRepresentationForCreation entry)
        {
            var entryFordb = Mapper.Map<InspectionSummaryRepresentationForCreation, Shared.InspectionSummary>(entry);
            var id  =BusinessComponent.Create(entryFordb).InspectionSummaryId;            
            var inspectionSummaryFromDataAccess = BusinessComponent.SingleOrDefault(new InspectionSummaryParametersQuery(id));
            if (inspectionSummaryFromDataAccess == null)
            {
                return NotFound();
            }
            MailService mailService = new MailService();
            mailService.ReportItems = Mapper.Map<List<EquipmentReportItemRepresentation>,List<EquipmentReportItem>>( entry.ReportItems);
            mailService.PLG_Mail = entry.PLG_Mail;
            BusinessComponent.MailService = mailService;
            BusinessComponent.Notify(inspectionSummaryFromDataAccess);
            CreatedRepresentation result = new CreatedRepresentation(Url.Route(nameof(InspectionSummaryGetById), new { id = entryFordb.InspectionSummaryId }));
            return CreatedAtRoute(nameof(InspectionSummaryGetById), new { id = entryFordb.InspectionSummaryId }, result);            
        }
    }
}
