using System.Management.Automation;
using PnP.PowerShell.Commands.Attributes;
using PnP.PowerShell.Commands.Base;
using PnP.PowerShell.Commands.Base.PipeBinds;
using PnP.PowerShell.Commands.Utilities;

namespace PnP.PowerShell.Commands.Planner
{
    [Cmdlet(VerbsCommon.Remove, "PlannerTask")]
    [MicrosoftGraphApiPermissionCheck(MicrosoftGraphApiPermission.Group_Read_All)]
    [MicrosoftGraphApiPermissionCheck(MicrosoftGraphApiPermission.Group_ReadWrite_All)]
    [PnPManagementShellScopes("Group.ReadWrite.All")]
    public class RemovePlannerTask : PnPGraphCmdlet
    {
        [Parameter(Mandatory = true, HelpMessage = "Specify the id or Task object to delete.")]
        public PlannerTaskPipeBind Task;

        protected override void ExecuteCmdlet()
        {
            PlannerUtility.DeleteTaskAsync(HttpClient, AccessToken, Task.Id).GetAwaiter().GetResult();
        }
    }
}