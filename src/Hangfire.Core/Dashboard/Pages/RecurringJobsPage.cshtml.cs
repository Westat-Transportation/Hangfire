#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.States;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class RecurringJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");











            
            #line 11 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
  
    Layout = new LayoutPage(Strings.RecurringJobsPage_Title);
	List<RecurringJobDto> recurringJobs;
    
    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    Pager pager = null;

	using (var connection = Storage.GetConnection())
	{
	    var storageConnection = connection as JobStorageConnection;
	    if (storageConnection != null)
	    {
	        pager = new Pager(from, perPage, storageConnection.GetRecurringJobCount());
	        recurringJobs = storageConnection.GetRecurringJobs(pager.FromRecord, pager.FromRecord + pager.RecordsPerPage - 1);
	    }
	    else
	    {
            recurringJobs = connection.GetRecurringJobs();
	    }
	}


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"page-header\"" +
">");


            
            #line 39 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                           Write(Strings.RecurringJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");


            
            #line 40 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
         if (recurringJobs.Count == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 43 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
           Write(Strings.RecurringJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 45 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n");


            
            #line 50 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-primar" +
"y\"\r\n                                data-url=\"");


            
            #line 53 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     Write(Url.To("/recurring/trigger"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 54 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                              Write(Strings.RecurringJobsPage_Triggering);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-play-circle\"></span>\r\n                     " +
"       ");


            
            #line 57 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                       Write(Strings.RecurringJobsPage_TriggerNow);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 59 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 60 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (!IsReadOnly)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <button class=\"js-jobs-list-command btn btn-sm btn-defaul" +
"t\"\r\n                                data-url=\"");


            
            #line 63 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     Write(Url.To("/recurring/remove"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-loading-text=\"");


            
            #line 64 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                              Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                data-confirm=\"");


            
            #line 65 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                                disabled=\"disabled\">\r\n                        " +
"    <span class=\"glyphicon glyphicon-remove\"></span>\r\n                          " +
"  ");


            
            #line 68 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                       Write(Strings.Common_Delete);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </button>\r\n");


            
            #line 70 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden

            
            #line 71 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (pager != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral(" ");


            
            #line 73 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                      Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 74 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n\r\n                <div class=\"table-responsive\">\r\n       " +
"             <table class=\"table\">\r\n                        <thead>\r\n           " +
"                 <tr>\r\n");


            
            #line 81 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 if (!IsReadOnly)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <th class=\"min-width\">\r\n                     " +
"                   <input type=\"checkbox\" class=\"js-jobs-list-select-all\"/>\r\n   " +
"                                 </th>\r\n");


            
            #line 86 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <th>");


            
            #line 87 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"min-width\">");


            
            #line 88 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(Strings.RecurringJobsPage_Table_Cron);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 89 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(Strings.RecurringJobsPage_Table_TimeZone);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th>");


            
            #line 90 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 91 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.RecurringJobsPage_Table_NextExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 92 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.RecurringJobsPage_Table_LastExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                                <th class=\"align-right min-width\">");


            
            #line 93 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                             Write(Strings.Common_Created);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                            </tr>\r\n                        </thead>\r\n     " +
"                   <tbody>\r\n");


            
            #line 97 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             foreach (var job in recurringJobs)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <tr class=\"js-jobs-list-row hover\">\r\n");


            
            #line 100 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     if (!IsReadOnly)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <td rowspan=\"");


            
            #line 102 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 Write(job.Error != null ? "2" : "1");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                            <input type=\"checkbox\" class=\"js-" +
"jobs-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 103 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                 Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n                                        </td>\r\n");


            
            #line 105 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <td class=\"word-break width-15\">");


            
            #line 106 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                               Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                                    <td style=\"min-width: 125px\" class=\"mi" +
"n-width\">\r\n                                        ");



WriteLiteral("\r\n");


            
            #line 109 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          
                                            string cronDescription = null;
                                            bool cronError = false;

                                            if (!String.IsNullOrEmpty(job.Cron))
                                            {
                                                try
                                                {
                                                    RecurringJobEntity.ParseCronExpression(job.Cron);
                                                }
                                                catch (Exception ex)
                                                {
                                                    cronDescription = ex.Message;
                                                    cronError = true;
                                                }

                                                if (cronDescription == null)
                                                {
#if FEATURE_CRONDESCRIPTOR
                                                    try
                                                    {
                                                        cronDescription = CronExpressionDescriptor.ExpressionDescriptor.GetDescription(job.Cron);
                                                    }
                                                    catch (FormatException)
                                                    {
                                                    }
#endif
                                                }
                                            }
                                        

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 140 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (cronDescription != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                        <code title=\"");


            
            #line 142 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                Write(cronDescription);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"cron-badge\">\r\n");


            
            #line 143 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                             if (cronError)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <span class=\"glyphicon glyphicon-" +
"exclamation-sign\"></span>\r\n");


            
            #line 146 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                            ");


            
            #line 147 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(job.Cron);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </code>\r\n");


            
            #line 149 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <code class=\"cron-badge\">");


            
            #line 152 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                Write(job.Cron);

            
            #line default
            #line hidden
WriteLiteral("</code>\r\n");


            
            #line 153 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d>\r\n");


            
            #line 156 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (!String.IsNullOrWhiteSpace(job.TimeZoneId))
                                        {
                                            string displayName;
                                            Exception exception = null;

                                            try
                                            {
                                                var resolver = DashboardOptions.TimeZoneResolver ?? new DefaultTimeZoneResolver();
                                                displayName = resolver.GetTimeZoneById(job.TimeZoneId).DisplayName;
                                            }
                                            catch (Exception ex)
                                            {
                                                displayName = null;
                                                exception = ex;
                                            }


            
            #line default
            #line hidden
WriteLiteral("                                            <span title=\"");


            
            #line 172 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(displayName);

            
            #line default
            #line hidden
WriteLiteral("\" data-container=\"body\">");


            
            #line 172 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                        Write(job.TimeZoneId);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 173 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                 if (exception != null)
                                                {

            
            #line default
            #line hidden
WriteLiteral("                                                    <span class=\"glyphicon glyphi" +
"con-exclamation-sign\" title=\"");


            
            #line 175 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                         Write(exception.Message);

            
            #line default
            #line hidden
WriteLiteral("\"></span>\r\n");


            
            #line 176 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                }

            
            #line default
            #line hidden
WriteLiteral("                                            </span>\r\n");


            
            #line 178 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            ");

WriteLiteral(" UTC\r\n");


            
            #line 182 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"word-break width-30\">\r\n");


            
            #line 185 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.Job != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            ");

WriteLiteral(" ");


            
            #line 187 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Html.JobName(job.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 188 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else if (job.LoadException != null && job.LoadException.InnerException != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 191 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(job.LoadException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 192 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else if (job.LoadException != null)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 195 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(job.LoadException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 196 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 199 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 200 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 203 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (!job.NextExecution.HasValue)
                                        {
                                            if (job.Error != null)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <span class=\"label label-danger t" +
"ext-uppercase\">");


            
            #line 207 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                           Write(Strings.Common_Error);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 208 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <span class=\"label label-default " +
"text-uppercase\" title=\"");


            
            #line 211 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                   Write(Strings.RecurringJobsPage_RecurringJobDisabled_Tooltip);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 211 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                                                            Write(Strings.Common_Disabled);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 212 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }

                                        }
                                        else if (job.RetryAttempt > 0)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <span class=\"label label-warning\">");


            
            #line 217 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                         Write(Html.RelativeTime(job.NextExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 218 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }
                                        else
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 221 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.NextExecution.Value));

            
            #line default
            #line hidden
            
            #line 221 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                       
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 225 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.LastExecution != null)
                                        {
                                            if (!String.IsNullOrEmpty(job.LastJobId))
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <a href=\"");


            
            #line 229 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    Write(Url.JobDetails(job.LastJobId));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"text-decoration: none\">\r\n");


            
            #line 230 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                      
                                                        var cssSuffix = JobHistoryRenderer.GetStateCssSuffix(job.LastJobState ?? EnqueuedState.StateName);
                                                    

            
            #line default
            #line hidden

            
            #line 233 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                     if (cssSuffix != null)
                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                        <span class=\"label label-" +
"default label-hover label-state-");


            
            #line 235 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                            Write(cssSuffix);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                            ");


            
            #line 236 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                       Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                        </span>\r\n");


            
            #line 238 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    }
                                                    else
                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                        <span class=\"label label-" +
"default label-hover\" style=\"");


            
            #line 241 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                         Write($"background-color: {JobHistoryRenderer.GetForegroundStateColor(job.LastJobState ?? EnqueuedState.StateName)};");

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                            ");


            
            #line 242 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                       Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                        </span>\r\n");


            
            #line 244 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                    }

            
            #line default
            #line hidden
WriteLiteral("                                                </a>\r\n");


            
            #line 246 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                            else
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <em>\r\n                           " +
"                         ");


            
            #line 250 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                               Write(Strings.RecurringJobsPage_Canceled);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 250 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                   Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                                </em>\r\n");


            
            #line 252 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            }
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>");


            
            #line 256 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 257 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n                                    <t" +
"d class=\"align-right min-width\">\r\n");


            
            #line 260 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         if (job.CreatedAt != null)
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 262 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Html.RelativeTime(job.CreatedAt.Value));

            
            #line default
            #line hidden
            
            #line 262 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                   
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <em>N/A</em>\r\n");


            
            #line 267 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </td>\r\n");


            
            #line 269 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     if (job.Error != null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <tr>\r\n                                   " +
"         <td colspan=\"");


            
            #line 272 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                     Write(IsReadOnly ? "6" : "7");

            
            #line default
            #line hidden
WriteLiteral("\" class=\"failed-job-details\">\r\n                                                <p" +
"re class=\"stack-trace\"><code>");


            
            #line 273 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                          Write(Html.StackTrace(job.Error));

            
            #line default
            #line hidden
WriteLiteral("</code></pre>\r\n                                            </td>\r\n               " +
"                         </tr>\r\n");


            
            #line 276 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </tr>\r\n");


            
            #line 278 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                             }

            
            #line default
            #line hidden
WriteLiteral("                        </tbody>\r\n                    </table>\r\n                <" +
"/div>\r\n\r\n");


            
            #line 283 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                 if (pager != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral(" ");


            
            #line 285 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                  Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 286 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 288 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>    ");


        }
    }
}
#pragma warning restore 1591
