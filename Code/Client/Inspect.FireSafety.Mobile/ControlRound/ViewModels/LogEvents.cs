using Inspect.Mobile.Framework.Xamarin.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inspect.FireSafety.Mobile.ControlRound.ViewModels
{
    public static class LogEvents
    {
        public static void UserNotFound(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Can't find user check the login data");
            logger.Log(logEvent);
        }
        public static void UserFailtLogin(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Error, "Failed to login, see exception details for more info", ex);
            logger.Log(logEvent);
        }
        public static void ValidateUser(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "validate user started");
            logger.Log(logEvent);
        }

        public static void ValidateCompleted(this ILogger logger, string extra = null)
        {
            var logEvent = LogEvent.Create(Level.Info, "validate user completed. " + extra);
            logger.Log(logEvent);
        }

        public static void GettingOrganisationUnitsStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get OrganisationUnits from server stared");
            logger.Log(logEvent);
        }
        public static void GettingLocationsStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get OrganisationUnits from server started");
            logger.Log(logEvent);
        }
        public static void GetOrganisationUnitsCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get OrganisationUnits from server Completed");
            logger.Log(logEvent);
        }
        public static void GetLocationsCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get locations from server Completed");
            logger.Log(logEvent);
        }
        public static void GetOrganisationUnitsFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to get the OrganisationUnits. See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void GetLocationsFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to get the zone of the department. See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void FilterChanged(this ILogger logger, string filter)
        {
            var logEvent = LogEvent.Create(Level.Info, "Filter changed to : " + filter);
            logger.Log(logEvent);
        }

        public static void Scanning(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "reading QR-code with scanner");
            logger.Log(logEvent);
        }
        public static void ScanningFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed reading QR-code with scanner");
            logger.Log(logEvent);
        }
        public static void ScanningCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Scanning Completed");
            logger.Log(logEvent);
        }
        public static void CheckEndControl(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Checking if round is done");
            logger.Log(logEvent);
        }
        public static void CheckEndControlCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Control round completed");
            logger.Log(logEvent);
        }
        public static void GettingInspectionItemsStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get InspectionItems from server started");
            logger.Log(logEvent);
        }
        public static void GetInspectionItemsFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to get the InspectionItems. See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void GetInspectionItemsCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get InspectionItems from server Completed");
            logger.Log(logEvent);
        }
        public static void LoadInspectionItemsFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to load the InspectionItems. See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void LoadInspectionItemsCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Load  InspectionItems completed");
            logger.Log(logEvent);
        }
        public static void LoadInspectionItemsStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Load  InspectionItems started");
            logger.Log(logEvent);
        }

        public static void FeedbackMessageSended(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "The feedback message sended");
            logger.Log(logEvent);
        }
        public static void FailedToFindEquipment(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to find equipment. See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void SearchingEquipmentStared(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Failed to find equipment. ");
            logger.Log(logEvent);
        }
        public static void RefreshingOverview(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Refreshing overview page");
            logger.Log(logEvent);
        }
        public static void ControlRoundHasStopped(this ILogger logger, string remark)
        {
            var logEvent = LogEvent.Create(Level.Info, "controle round has stopped with remark : " +remark);
            logger.Log(logEvent);
        }
        public static void SendStopSummeryFailed(this ILogger logger, Exception e)
        {
            var logEvent = LogEvent.Create(Level.Info, "The summery for stop failed  save to server. See the exception details for more info.", e);
            logger.Log(logEvent);
        }

        public static void SavedFeedbackToDatabaseFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to save the Feedback to the database . See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void SavedFeedbackToDatabaseCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "save Feedback to database completed");
            logger.Log(logEvent);
        }
        public static void SavedFeedbackToDatabaseStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "save Feedback to database started");
            logger.Log(logEvent);
        }
        public static void UpdateFeedbackToDatabaseFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to update the Feedback to the database . See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void UpdateFeedbackToDatabaseCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "update Feedback to database completed");
            logger.Log(logEvent);
        }
        public static void UpdateFeedbackToDatabaseStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "update Feedback to database started");
            logger.Log(logEvent);
        }
        public static void UpdateFeedbackPhotosToDatabaseCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "update Feedback photo's to database completed");
            logger.Log(logEvent);
        }
        public static void UpdateFeedbackPhotosToDatabaseStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "update Feedback photo's to database completed");
            logger.Log(logEvent);
        }
        public static void SaveFeedbackPhotosToDatabaseCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "save Feedback photo's to database completed");
            logger.Log(logEvent);
        }
        public static void SaveFeedbackPhotosToDatabaseStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "save Feedback photo's to database completed");
            logger.Log(logEvent);
        }

        public static void GettingHisoryItems(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Gettting the history of feedback items");
            logger.Log(logEvent);
        }
        public static void GettingHisoryItemsFailed(this ILogger logger,Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, " Failed to get the history of feedback items See the exception details for more info.", ex);
            logger.Log(logEvent);
        }

        public static void GettingFeedbackItemsStarted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get InspectionItems from server started");
            logger.Log(logEvent);
        }
        public static void GetFeedbackItemsFailed(this ILogger logger, Exception ex)
        {
            var logEvent = LogEvent.Create(Level.Warn, "Failed to get the InspectionItems. See the exception details for more info.", ex);
            logger.Log(logEvent);
        }
        public static void GetFeedbackItemsCompleted(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Get InspectionItems from server Completed");
            logger.Log(logEvent);
        }
        public static void TakingAPhoto(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Taking a photo");
            logger.Log(logEvent);
        }
        public static void DeletingAPhoto(this ILogger logger)
        {
            var logEvent = LogEvent.Create(Level.Info, "Deleting a photo");
            logger.Log(logEvent);
        }
        public static void LoggingOutUser(this ILogger logger,string name)
        {
            var logEvent = LogEvent.Create(Level.Info, "Logging out :"+name);
            logger.Log(logEvent);
        }
    }
}
