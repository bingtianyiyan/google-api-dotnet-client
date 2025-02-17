// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Genomics.v1
{
    /// <summary>The Genomics Service.</summary>
    public class GenomicsService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public GenomicsService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public GenomicsService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Operations = new OperationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "genomics";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://genomics.googleapis.com/";
        #else
            "https://genomics.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://genomics.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Genomics API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Genomics data</summary>
            public static string Genomics = "https://www.googleapis.com/auth/genomics";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Genomics API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Genomics data</summary>
            public const string Genomics = "https://www.googleapis.com/auth/genomics";
        }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }
    }

    /// <summary>A base abstract class for Genomics requests.</summary>
    public abstract class GenomicsBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new GenomicsBaseServiceRequest instance.</summary>
        protected GenomicsBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Genomics parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients may use Operations.GetOperation or
        /// Operations.ListOperations to check whether the cancellation succeeded or the operation completed despite
        /// cancellation. Authorization requires the following [Google IAM](https://cloud.google.com/iam) permission: *
        /// `genomics.operations.cancel`
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.Genomics.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. Clients may use Operations.GetOperation or
        /// Operations.ListOperations to check whether the cancellation succeeded or the operation completed despite
        /// cancellation. Authorization requires the following [Google IAM](https://cloud.google.com/iam) permission: *
        /// `genomics.operations.cancel`
        /// </summary>
        public class CancelRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.Genomics.v1.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Genomics.v1.Data.CancelOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service. Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam) permission: * `genomics.operations.get`
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service. Authorization requires the following [Google
        /// IAM](https://cloud.google.com/iam) permission: * `genomics.operations.get`
        /// </summary>
        public class GetRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission: * `genomics.operations.list`
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. Authorization requires the following
        /// [Google IAM](https://cloud.google.com/iam) permission: * `genomics.operations.list`
        /// </summary>
        public class ListRequest : GenomicsBaseServiceRequest<Google.Apis.Genomics.v1.Data.ListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation's parent resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// A string for filtering Operations. In v2alpha1, the following filter fields are supported: * createTime:
            /// The time this job was created * events: The set of event (names) that have occurred while running the
            /// pipeline. The : operator can be used to determine if a particular event has occurred. * error: If the
            /// pipeline is running, this value is NULL. Once the pipeline finishes, the value is the standard Google
            /// error code. * labels.key or labels."key with space" where key is a label key. * done: If the pipeline is
            /// running, this value is false. Once the pipeline finishes, the value is true. In v1 and v1alpha2, the
            /// following filter fields are supported: * projectId: Required. Corresponds to
            /// OperationMetadata.projectId. * createTime: The time this job was created, in seconds from the
            /// [epoch](http://en.wikipedia.org/wiki/Unix_time). Can use `&amp;gt;=` and/or `&amp;lt;=` operators. *
            /// status: Can be `RUNNING`, `SUCCESS`, `FAILURE`, or `CANCELED`. Only one status may be specified. *
            /// labels.key where key is a label key. Examples: * `projectId = my-project AND createTime &amp;gt;=
            /// 1432140000` * `projectId = my-project AND createTime &amp;gt;= 1432140000 AND createTime &amp;lt;=
            /// 1432150000 AND status = RUNNING` * `projectId = my-project AND labels.color = *` * `projectId =
            /// my-project AND labels.color = red`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The maximum number of results to return. The maximum value is 256.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The standard list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations$",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }
}
namespace Google.Apis.Genomics.v1.Data
{
    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Describes a Compute Engine resource that is being managed by a running pipeline.</summary>
    public class ComputeEngine : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The names of the disks that were created for this pipeline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskNames")]
        public virtual System.Collections.Generic.IList<string> DiskNames { get; set; }

        /// <summary>The instance on which the operation is running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instanceName")]
        public virtual string InstanceName { get; set; }

        /// <summary>The machine type of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The availability zone in which the instance resides.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when a container is forcibly terminated by the worker. Currently, this only occurs when the
    /// container outlives the timeout specified by the user.
    /// </summary>
    public class ContainerKilledEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a container starts.</summary>
    public class ContainerStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>
        /// The public IP address that can be used to connect to the container. This field is only populated when at
        /// least one port mapping is present. If the instance was created with a private address, this field will be
        /// empty even if port mappings exist.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress { get; set; }

        /// <summary>
        /// The container-to-host port mappings installed for this container. This set will contain any ports exposed
        /// using the `PUBLISH_EXPOSED_PORTS` flag as well as any specified in the `Action` definition.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("portMappings")]
        public virtual System.Collections.Generic.IDictionary<string, System.Nullable<int>> PortMappings { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when a container exits.</summary>
    public class ContainerStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started this container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; }

        /// <summary>
        /// The tail end of any content written to standard error by the container. If the content emits large amounts
        /// of debugging noise or contains sensitive information, you can prevent the content from being printed by
        /// setting the `DISABLE_STANDARD_ERROR_CAPTURE` flag. Note that only a small amount of the end of the stream is
        /// captured here. The entire stream is stored in the `/google/logs` directory mounted into each action, and can
        /// be copied off the machine as described elsewhere.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stderr")]
        public virtual string Stderr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated whenever a resource limitation or transient error delays execution of a pipeline that was
    /// otherwise ready to run.
    /// </summary>
    public class DelayedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A textual description of the cause of the delay. The string can change without notice because it is often
        /// generated by another service (such as Compute Engine).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>
        /// If the delay was caused by a resource shortage, this field lists the Compute Engine metrics that are
        /// preventing this operation from running (for example, `CPUS` or `INSTANCES`). If the particular metric is not
        /// known, a single `UNKNOWN` metric will be present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metrics")]
        public virtual System.Collections.Generic.IList<string> Metrics { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Carries information about events that occur during pipeline execution.</summary>
    public class Event : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A human-readable description of the event. Note that these strings can change at any time without notice.
        /// Any application logic must use the information in the `details` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Machine-readable details about the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IDictionary<string, object> Details { get; set; }

        /// <summary>The time at which the event occurred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timestamp")]
        public virtual object Timestamp { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the execution of a pipeline has failed. Note that other events can continue to occur
    /// after this event.
    /// </summary>
    public class FailedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the cause of the failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; }

        /// <summary>The Google standard error code that best describes this failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>An OperationMetadata or Metadata object. This will always be returned with the Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. For
        /// example: `operations/CJHU7Oi_ChDrveSpBRjfuL-qzoWAgEw`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>An Empty object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event that occurred during an Operation.</summary>
    public class OperationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required description of event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Optional time of when event finished. An event can have a start time and no finish time. If an event has a
        /// finish time, there must be a start time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>Optional time of when event started.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Metadata describing an Operation.</summary>
    public class OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This field is deprecated. Use `labels` instead. Optionally provided by the caller when submitting the
        /// request that creates the operation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; }

        /// <summary>The time at which the job was submitted to the Genomics service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>The time at which the job stopped running.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>
        /// Optional event messages that were generated during the job's execution. This also contains any warnings that
        /// were generated during import or export.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<OperationEvent> Events { get; set; }

        /// <summary>Optionally provided by the caller when submitting the request that creates the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels { get; set; }

        /// <summary>The Google Cloud Project in which the job is scoped.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; }

        /// <summary>
        /// The original request that started the operation. Note that this will be in current version of the API. If
        /// the operation was started with v1beta2 API and a GetOperation is performed on v1 API, a v1 request will be
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("request")]
        public virtual System.Collections.Generic.IDictionary<string, object> Request { get; set; }

        /// <summary>Runtime metadata on this Operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("runtimeMetadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> RuntimeMetadata { get; set; }

        /// <summary>The time at which the job began to run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when the worker starts pulling an image.</summary>
    public class PullStartedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated when the worker stops pulling an image.</summary>
    public class PullStoppedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the image that was pulled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to the RunPipeline method, returned in the operation's result field on success.</summary>
    public class RunPipelineResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Runtime metadata that will be populated in the runtimeMetadata field of the Operation associated with a
    /// RunPipeline execution.
    /// </summary>
    public class RuntimeMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Execution information specific to Google Compute Engine.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("computeEngine")]
        public virtual ComputeEngine ComputeEngine { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the execution of a container results in a non-zero exit status that was not otherwise
    /// ignored. Execution will continue, but only actions that are flagged as `ALWAYS_RUN` will be executed. Other
    /// actions will be skipped.
    /// </summary>
    public class UnexpectedExitStatusEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The numeric ID of the action that started the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actionId")]
        public virtual System.Nullable<int> ActionId { get; set; }

        /// <summary>The exit status of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exitStatus")]
        public virtual System.Nullable<int> ExitStatus { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An event generated after a worker VM has been assigned to run the pipeline.</summary>
    public class WorkerAssignedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The machine type that was assigned for the worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("machineType")]
        public virtual string MachineType { get; set; }

        /// <summary>The zone the worker is running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An event generated when the worker VM that was assigned to the pipeline has been released (deleted).
    /// </summary>
    public class WorkerReleasedEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The worker's instance name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instance")]
        public virtual string Instance { get; set; }

        /// <summary>The zone the worker was running in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("zone")]
        public virtual string Zone { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
