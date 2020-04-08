using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevAzureManager.Models.Azure
{
    public class Links
    {
        public Avatar avatar { get; set; }
    }

    public class ModifiedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class Avatar2
    {
        public string href { get; set; }
    }

    public class Links2
    {
        public Avatar2 avatar { get; set; }
    }

    public class CreatedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links2 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class Avatar3
    {
        public string href { get; set; }
    }

    public class Links3
    {
        public Avatar3 avatar { get; set; }
    }

    public class CreatedFor
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links3 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class Variables
    {
    }

    public class AppPoolPrefixApi
    {
        public string value { get; set; }
    }

    public class AppPoolPrefixFront
    {
        public string value { get; set; }
    }

    public class AppPoolPrefixGwEntrada
    {
        public string value { get; set; }
    }

    public class AppPoolPrefixGwSaida
    {
        public string value { get; set; }
    }

    public class AppPoolPrefixServicosPagou
    {
        public string value { get; set; }
    }

    public class CertificadoSSL
    {
        public string value { get; set; }
    }

    public class ParentWebsiteApi
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFront
    {
        public string value { get; set; }
    }

    public class ParentWebsiteGwEntrada
    {
        public string value { get; set; }
    }

    public class ParentWebsiteGwSaida
    {
        public string value { get; set; }
    }

    public class ParentWebsiteServicosPagou
    {
        public string value { get; set; }
    }

    public class PhysicalPathApi
    {
        public string value { get; set; }
    }

    public class PhysicalPathFront
    {
        public string value { get; set; }
    }

    public class PhysicalPathGwEntrada
    {
        public string value { get; set; }
    }

    public class PhysicalPathGwSaida
    {
        public string value { get; set; }
    }

    public class PhysicalPathServicosPagou
    {
        public string value { get; set; }
    }

    public class UrlApi
    {
        public string value { get; set; }
    }

    public class UrlBaseFront
    {
        public string value { get; set; }
    }

    public class UrlFront
    {
        public string value { get; set; }
    }

    public class UrlFrontAcionamento
    {
        public string value { get; set; }
    }

    public class UrlGW
    {
        public string value { get; set; }
    }

    public class UrlGWSaida
    {
        public string value { get; set; }
    }

    public class UrlServicosPagou
    {
        public string value { get; set; }
    }

    public class VirtualPathApi
    {
        public string value { get; set; }
    }

    public class VirtualPathFront
    {
        public string value { get; set; }
    }

    public class VirtualPathGwEntrada
    {
        public string value { get; set; }
    }

    public class VirtualPathGwSaida
    {
        public string value { get; set; }
    }

    public class VirtualPathServicosPagou
    {
        public string value { get; set; }
    }

    public class CaminhoRaizSite
    {
        public string value { get; set; }
    }

    public class CertificadoSSLChatbot
    {
        public string value { get; set; }
    }

    public class ParentWebsiteGwEntradaChatbot
    {
        public string value { get; set; }
    }

    public class UrlGWChatbot
    {
        public string value { get; set; }
    }

    public class PastaInstalacaoMetricBeat
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFrontAcionamento
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFrontGestao
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFrontOperacaoPaschoalotto
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFrontPagouFacilB2b
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFrontPagouFacilB2c
    {
        public string value { get; set; }
    }

    public class ParentWebsiteFrontParceiro
    {
        public string value { get; set; }
    }

    public class UrlFrontGestaoProduto
    {
        public string value { get; set; }
    }

    public class UrlFrontOperacaoPaschoalotto
    {
        public string value { get; set; }
    }

    public class UrlFrontPagouFacilB2b
    {
        public string value { get; set; }
    }

    public class UrlFrontPagouFacilB2C
    {
        public string value { get; set; }
    }

    public class UrlFrontParceiro
    {
        public string value { get; set; }
    }

    public class Variables2
    {
        public AppPoolPrefixApi AppPoolPrefixApi { get; set; }
        public AppPoolPrefixFront AppPoolPrefixFront { get; set; }
        public AppPoolPrefixGwEntrada AppPoolPrefixGwEntrada { get; set; }
        public AppPoolPrefixGwSaida AppPoolPrefixGwSaida { get; set; }
        public AppPoolPrefixServicosPagou AppPoolPrefixServicosPagou { get; set; }
        public CertificadoSSL CertificadoSSL { get; set; }
        public ParentWebsiteApi ParentWebsiteApi { get; set; }
        public ParentWebsiteFront ParentWebsiteFront { get; set; }
        public ParentWebsiteGwEntrada ParentWebsiteGwEntrada { get; set; }
        public ParentWebsiteGwSaida ParentWebsiteGwSaida { get; set; }
        public ParentWebsiteServicosPagou ParentWebsiteServicosPagou { get; set; }
        public PhysicalPathApi PhysicalPathApi { get; set; }
        public PhysicalPathFront PhysicalPathFront { get; set; }
        public PhysicalPathGwEntrada PhysicalPathGwEntrada { get; set; }
        public PhysicalPathGwSaida PhysicalPathGwSaida { get; set; }
        public PhysicalPathServicosPagou PhysicalPathServicosPagou { get; set; }
        public UrlApi UrlApi { get; set; }
        public UrlBaseFront UrlBaseFront { get; set; }
        public UrlFront UrlFront { get; set; }
        public UrlFrontAcionamento UrlFrontAcionamento { get; set; }
        public UrlGW UrlGW { get; set; }
        public UrlGWSaida UrlGWSaida { get; set; }
        public UrlServicosPagou UrlServicosPagou { get; set; }
        public VirtualPathApi VirtualPathApi { get; set; }
        public VirtualPathFront VirtualPathFront { get; set; }
        public VirtualPathGwEntrada VirtualPathGwEntrada { get; set; }
        public VirtualPathGwSaida VirtualPathGwSaida { get; set; }
        public VirtualPathServicosPagou VirtualPathServicosPagou { get; set; }
        public CaminhoRaizSite CaminhoRaizSite { get; set; }
        public CertificadoSSLChatbot CertificadoSSLChatbot { get; set; }
        public ParentWebsiteGwEntradaChatbot ParentWebsiteGwEntradaChatbot { get; set; }
        public UrlGWChatbot UrlGWChatbot { get; set; }
        public PastaInstalacaoMetricBeat PastaInstalacaoMetricBeat { get; set; }
        public ParentWebsiteFrontAcionamento ParentWebsiteFrontAcionamento { get; set; }
        public ParentWebsiteFrontGestao ParentWebsiteFrontGestao { get; set; }
        public ParentWebsiteFrontOperacaoPaschoalotto ParentWebsiteFrontOperacaoPaschoalotto { get; set; }
        public ParentWebsiteFrontPagouFacilB2b ParentWebsiteFrontPagouFacilB2b { get; set; }
        public ParentWebsiteFrontPagouFacilB2c ParentWebsiteFrontPagouFacilB2c { get; set; }
        public ParentWebsiteFrontParceiro ParentWebsiteFrontParceiro { get; set; }
        public UrlFrontGestaoProduto UrlFrontGestaoProduto { get; set; }
        public UrlFrontOperacaoPaschoalotto UrlFrontOperacaoPaschoalotto { get; set; }
        public UrlFrontPagouFacilB2b UrlFrontPagouFacilB2b { get; set; }
        public UrlFrontPagouFacilB2C UrlFrontPagouFacilB2C { get; set; }
        public UrlFrontParceiro UrlFrontParceiro { get; set; }
    }

    public class VariableGroup
    {
        public Variables2 variables { get; set; }
        public string type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public bool isShared { get; set; }
        public object variableGroupProjectReferences { get; set; }
    }

    public class Avatar4
    {
        public string href { get; set; }
    }

    public class Links4
    {
        public Avatar4 avatar { get; set; }
    }

    public class Approval
    {
        public int rank { get; set; }
        public bool isAutomated { get; set; }
        public bool isNotificationOn { get; set; }
        public int id { get; set; }
        public Approver approver { get; set; }
    }

    public class ApprovalOptions
    {
        public object requiredApproverCount { get; set; }
        public bool releaseCreatorCanBeApprover { get; set; }
        public bool autoTriggeredAndPreviousEnvironmentApprovedCanBeSkipped { get; set; }
        public bool enforceIdentityRevalidation { get; set; }
        public int timeoutInMinutes { get; set; }
        public string executionOrder { get; set; }
    }

    public class PreApprovalsSnapshot
    {
        public List<Approval> approvals { get; set; }
        public ApprovalOptions approvalOptions { get; set; }
    }

    public class Approval2
    {
        public int rank { get; set; }
        public bool isAutomated { get; set; }
        public bool isNotificationOn { get; set; }
        public int id { get; set; }
    }

    public class ApprovalOptions2
    {
        public object requiredApproverCount { get; set; }
        public bool releaseCreatorCanBeApprover { get; set; }
        public bool autoTriggeredAndPreviousEnvironmentApprovedCanBeSkipped { get; set; }
        public bool enforceIdentityRevalidation { get; set; }
        public int timeoutInMinutes { get; set; }
        public string executionOrder { get; set; }
    }

    public class PostApprovalsSnapshot
    {
        public List<Approval2> approvals { get; set; }
        public ApprovalOptions2 approvalOptions { get; set; }
    }

    public class EnvironmentOptions
    {
        public string emailNotificationType { get; set; }
        public string emailRecipients { get; set; }
        public bool skipArtifactsDownload { get; set; }
        public int timeoutInMinutes { get; set; }
        public bool enableAccessToken { get; set; }
        public bool publishDeploymentStatus { get; set; }
        public bool badgeEnabled { get; set; }
        public bool autoLinkWorkItems { get; set; }
        public bool pullRequestDeploymentEnabled { get; set; }
    }

    public class Condition
    {
        public bool? result { get; set; }
        public string name { get; set; }
        public string conditionType { get; set; }
        public string value { get; set; }
    }

    public class ArtifactsDownloadInput
    {
        public List<object> downloadInputs { get; set; }
    }

    public class OverrideInputs
    {
    }

    public class DeploymentInput
    {
        public int healthPercent { get; set; }
        public string deploymentHealthOption { get; set; }
        public List<string> tags { get; set; }
        public bool skipArtifactsDownload { get; set; }
        public ArtifactsDownloadInput artifactsDownloadInput { get; set; }
        public int queueId { get; set; }
        public List<object> demands { get; set; }
        public bool enableAccessToken { get; set; }
        public int timeoutInMinutes { get; set; }
        public int jobCancelTimeoutInMinutes { get; set; }
        public string condition { get; set; }
        public OverrideInputs overrideInputs { get; set; }
    }

    public class OverrideInputs2
    {
    }

    public class Inputs
    {
        public string EnableIIS { get; set; }
        public string IISDeploymentType { get; set; }
        public string ActionIISWebsite { get; set; }
        public string ActionIISApplicationPool { get; set; }
        public string StartStopWebsiteName { get; set; }
        public string WebsitePhysicalPath { get; set; }
        public string WebsitePhysicalPathAuth { get; set; }
        public string WebsiteAuthUserName { get; set; }
        public string WebsiteAuthUserPassword { get; set; }
        public string AddBinding { get; set; }
        public string Protocol { get; set; }
        public string IPAddress { get; set; }
        public string Port { get; set; }
        public string ServerNameIndication { get; set; }
        public string HostNameWithOutSNI { get; set; }
        public string HostNameWithHttp { get; set; }
        public string HostNameWithSNI { get; set; }
        public string SSLCertThumbPrint { get; set; }
        public string Bindings { get; set; }
        public string CreateOrUpdateAppPoolForWebsite { get; set; }
        public string ConfigureAuthenticationForWebsite { get; set; }
        public string AppPoolNameForWebsite { get; set; }
        public string DotNetVersionForWebsite { get; set; }
        public string PipeLineModeForWebsite { get; set; }
        public string AppPoolIdentityForWebsite { get; set; }
        public string AppPoolUsernameForWebsite { get; set; }
        public string AppPoolPasswordForWebsite { get; set; }
        public string AnonymousAuthenticationForWebsite { get; set; }
        public string BasicAuthenticationForWebsite { get; set; }
        public string WindowsAuthenticationForWebsite { get; set; }
        public string ParentWebsiteNameForVD { get; set; }
        public string VirtualPathForVD { get; set; }
        public string PhysicalPathForVD { get; set; }
        public string VDPhysicalPathAuth { get; set; }
        public string VDAuthUserName { get; set; }
        public string VDAuthUserPassword { get; set; }
        public string ParentWebsiteNameForApplication { get; set; }
        public string VirtualPathForApplication { get; set; }
        public string PhysicalPathForApplication { get; set; }
        public string ApplicationPhysicalPathAuth { get; set; }
        public string ApplicationAuthUserName { get; set; }
        public string ApplicationAuthUserPassword { get; set; }
        public string CreateOrUpdateAppPoolForApplication { get; set; }
        public string AppPoolNameForApplication { get; set; }
        public string DotNetVersionForApplication { get; set; }
        public string PipeLineModeForApplication { get; set; }
        public string AppPoolIdentityForApplication { get; set; }
        public string AppPoolUsernameForApplication { get; set; }
        public string AppPoolPasswordForApplication { get; set; }
        public string AppPoolName { get; set; }
        public string DotNetVersion { get; set; }
        public string PipeLineMode { get; set; }
        public string AppPoolIdentity { get; set; }
        public string AppPoolUsername { get; set; }
        public string AppPoolPassword { get; set; }
        public string StartStopRecycleAppPoolName { get; set; }
        public string AppCmdCommands { get; set; }
        public string WebSiteName { get; set; }
        public string VirtualApplication { get; set; }
        public string Package { get; set; }
        public string SetParametersFile { get; set; }
        public string RemoveAdditionalFilesFlag { get; set; }
        public string ExcludeFilesFromAppDataFlag { get; set; }
        public string TakeAppOfflineFlag { get; set; }
        public string AdditionalArguments { get; set; }
        public string XmlTransformation { get; set; }
        public string XmlVariableSubstitution { get; set; }
        public string JSONFiles { get; set; }
        public string SourceFolder { get; set; }
        public string Contents { get; set; }
        public string TargetFolder { get; set; }
        public string CleanTargetFolder { get; set; }
        public string OverWrite { get; set; }
        public string flattenFolders { get; set; }
        public string preserveTimestamp { get; set; }
        public string RemoveSourceFolder { get; set; }
        public string targetType { get; set; }
        public string filePath { get; set; }
        public string arguments { get; set; }
        public string script { get; set; }
        public string errorActionPreference { get; set; }
        public string failOnStderr { get; set; }
        public string ignoreLASTEXITCODE { get; set; }
        public string pwsh { get; set; }
        public string workingDirectory { get; set; }
    }

    public class Environment2
    {
    }

    public class WorkflowTask
    {
        public string taskId { get; set; }
        public string version { get; set; }
        public string name { get; set; }
        public string refName { get; set; }
        public bool enabled { get; set; }
        public bool alwaysRun { get; set; }
        public bool continueOnError { get; set; }
        public int timeoutInMinutes { get; set; }
        public string definitionType { get; set; }
        public OverrideInputs2 overrideInputs { get; set; }
        public string condition { get; set; }
        public Inputs inputs { get; set; }
        public Environment2 environment { get; set; }
    }

    public class DeployPhasesSnapshot
    {
        public DeploymentInput deploymentInput { get; set; }
        public int rank { get; set; }
        public string phaseType { get; set; }
        public string name { get; set; }
        public object refName { get; set; }
        public List<WorkflowTask> workflowTasks { get; set; }
    }

    public class Avatar5
    {
        public string href { get; set; }
    }

    public class Links5
    {
        public Avatar5 avatar { get; set; }
    }

    public class Owner
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links5 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class Web
    {
        public string href { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Links6
    {
        public Web web { get; set; }
        public Self self { get; set; }
    }
    
    public class Web2
    {
        public string href { get; set; }
    }

    public class Self2
    {
        public string href { get; set; }
    }

    public class Links7
    {
        public Web2 web { get; set; }
        public Self2 self { get; set; }
    }
    
    public class Avatar6
    {
        public string href { get; set; }
    }

    public class Links8
    {
        public Avatar6 avatar { get; set; }
    }

    public class ReleaseCreatedBy
    {
        public string displayName { get; set; }
        public string url { get; set; }
        public Links8 _links { get; set; }
        public string id { get; set; }
        public string uniqueName { get; set; }
        public string imageUrl { get; set; }
        public string descriptor { get; set; }
    }

    public class ProcessParameters
    {
    }

    public class GatesOptions
    {
        public bool isEnabled { get; set; }
        public int timeout { get; set; }
        public int samplingInterval { get; set; }
        public int stabilizationTime { get; set; }
        public int minimumSuccessDuration { get; set; }
    }

    public class PreDeploymentGatesSnapshot
    {
        public int id { get; set; }
        public GatesOptions gatesOptions { get; set; }
        public List<object> gates { get; set; }
    }

    public class PostDeploymentGatesSnapshot
    {
        public int id { get; set; }
        public object gatesOptions { get; set; }
        public List<object> gates { get; set; }
    }

    public class Environment
    {
        public int id { get; set; }
        public int releaseId { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public Variables variables { get; set; }
        public List<VariableGroup> variableGroups { get; set; }
        public List<object> preDeployApprovals { get; set; }
        public List<object> postDeployApprovals { get; set; }
        public PreApprovalsSnapshot preApprovalsSnapshot { get; set; }
        public PostApprovalsSnapshot postApprovalsSnapshot { get; set; }
        public List<object> deploySteps { get; set; }
        public int rank { get; set; }
        public int definitionEnvironmentId { get; set; }
        public EnvironmentOptions environmentOptions { get; set; }
        public List<object> demands { get; set; }
        public List<Condition> conditions { get; set; }
        public List<object> workflowTasks { get; set; }
        public List<DeployPhasesSnapshot> deployPhasesSnapshot { get; set; }
        public Owner owner { get; set; }
        public List<object> schedules { get; set; }
        public Release release { get; set; }
        public ReleaseDefinition releaseDefinition { get; set; }
        public ReleaseCreatedBy releaseCreatedBy { get; set; }
        public string triggerReason { get; set; }
        public ProcessParameters processParameters { get; set; }
        public PreDeploymentGatesSnapshot preDeploymentGatesSnapshot { get; set; }
        public PostDeploymentGatesSnapshot postDeploymentGatesSnapshot { get; set; }
        public DateTime? createdOn { get; set; }
        public DateTime? modifiedOn { get; set; }
    }

    public class NomeSite
    {
        public string value { get; set; }
    }

    public class Variables3
    {
        public NomeSite NomeSite { get; set; }
    }

    public class DeploySenha
    {
        public object value { get; set; }
        public bool isSecret { get; set; }
    }

    public class DeployUsuario
    {
        public string value { get; set; }
    }

    public class VariableGroup2
    {
        public string type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public bool isShared { get; set; }
        public object variableGroupProjectReferences { get; set; }
    }

    public class ArtifactSourceDefinitionUrl
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Branches
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class BuildUri
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class Definition
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class IsMultiDefinitionType
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class IsXamlBuildArtifactType
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class RepositoryProvider
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class Repository
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class RequestedFor
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class RequestedForId
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class SourceVersion
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class Version
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class ArtifactSourceVersionUrl
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Branch
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class CheckoutNestedSubmodules
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class CheckoutSubmodules
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class FetchDepth
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class GitLfsSupport
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class DefinitionReference
    {
        public ArtifactSourceDefinitionUrl artifactSourceDefinitionUrl { get; set; }
        public Branches branches { get; set; }
        public BuildUri buildUri { get; set; }
        public Definition definition { get; set; }
        public IsMultiDefinitionType IsMultiDefinitionType { get; set; }
        public IsXamlBuildArtifactType IsXamlBuildArtifactType { get; set; }
        public Project project { get; set; }
        public Repository repository { get; set; }
        public RequestedFor requestedFor { get; set; }
        public RequestedForId requestedForId { get; set; }
        public SourceVersion sourceVersion { get; set; }
        public Version version { get; set; }
        public ArtifactSourceVersionUrl artifactSourceVersionUrl { get; set; }
        public Branch branch { get; set; }
        public CheckoutNestedSubmodules checkoutNestedSubmodules { get; set; }
        public CheckoutSubmodules checkoutSubmodules { get; set; }
        public FetchDepth fetchDepth { get; set; }
        public GitLfsSupport gitLfsSupport { get; set; }
    }

    public class Artifact
    {
        public string sourceId { get; set; }
        public string type { get; set; }
        public string alias { get; set; }
        public DefinitionReference definitionReference { get; set; }
        public bool isPrimary { get; set; }
        public bool isRetained { get; set; }
    }

    public class Self3
    {
        public string href { get; set; }
    }

    public class Web3
    {
        public string href { get; set; }
    }

    public class Links9
    {
        public Self3 self { get; set; }
        public Web3 web { get; set; }
    }

    public class ReleaseDefinition2
    {
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public object projectReference { get; set; }
        public string url { get; set; }
        public Links9 _links { get; set; }
    }

    public class Self4
    {
        public string href { get; set; }
    }

    public class Web4
    {
        public string href { get; set; }
    }

    public class Links10
    {
        public Self4 self { get; set; }
        public Web4 web { get; set; }
    }

    public class ProjectReference
    {
        public string id { get; set; }
        public object name { get; set; }
    }

    public class Properties
    {
    }

    public class ReleaseDetailVSTSDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public DateTime createdOn { get; set; }
        public DateTime modifiedOn { get; set; }
        public ModifiedBy modifiedBy { get; set; }
        public CreatedBy createdBy { get; set; }
        public CreatedFor createdFor { get; set; }
        public List<Environment> environments { get; set; }
        public Variables3 variables { get; set; }
        public List<VariableGroup2> variableGroups { get; set; }
        public List<Artifact> artifacts { get; set; }
        public ReleaseDefinition2 releaseDefinition { get; set; }
        public int releaseDefinitionRevision { get; set; }
        public string description { get; set; }
        public string reason { get; set; }
        public string releaseNameFormat { get; set; }
        public bool keepForever { get; set; }
        public int definitionSnapshotRevision { get; set; }
        public string logsContainerUrl { get; set; }
        public string url { get; set; }
        public Links10 _links { get; set; }
        public List<object> tags { get; set; }
        public object triggeringArtifactAlias { get; set; }
        public ProjectReference projectReference { get; set; }
        public Properties properties { get; set; }
    }
}
