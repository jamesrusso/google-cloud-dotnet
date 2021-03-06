# Google Cloud Libraries for .NET
.NET idiomatic client libraries for [Google Cloud Platform](https://cloud.google.com/) services.

[![Travis build Status](https://travis-ci.org/googleapis/google-cloud-dotnet.svg?branch=master)](https://travis-ci.org/googleapis/google-cloud-dotnet)
[![Appveyor build status](https://ci.appveyor.com/api/projects/status/hkkyregfhh5m4d2u?svg=true)](https://ci.appveyor.com/project/googleapis/google-cloud-dotnet)
[![Coverage Status](https://codecov.io/gh/googleapis/google-cloud-dotnet/branch/master/graph/badge.svg)](https://codecov.io/gh/googleapis/google-cloud-dotnet)

* [Homepage](https://cloud.google.com/dotnet/)
* [API Documentation](http://googleapis.github.io/google-cloud-dotnet/docs/)

# Incompatibility with gRPC 2.x and C# 8 async sequences

All the GA releases currently available on NuGet depend on [GAX](https://github.com/googleapis/gax-dotnet) version 2.10 or earlier.

This makes them incompatible with any gRPC 2.x (including Grpc.Core, Grpc.Core.Api, Grpc.Net.Client, Grpc.AspNetCore etc), and also incompatible with the `await foreach` feature of C# 8, due to the dependency on System.Interactive.Async version 3.2.0.

We're planning on a major version bump, taking the opportunity to migrate to a new code generator at the same time. Please see the [documented plan](https://googleapis.github.io/google-cloud-dotnet/docs/major-version.html) and subscribe to the [tracking issue](https://github.com/googleapis/google-cloud-dotnet/issues/3519) for more information.

# Available APIs

The following libraries are available at a [GA](#versioning) quality level:

* [Google Cloud Asset Inventory](https://cloud.google.com/resource-manager/docs/cloud-asset-inventory/overview) - [V1 API docs](https://googleapis.dev/dotnet/Google.Cloud.Asset.V1/latest) (GA)
  * Additionally, the following library is available for access to beta API functionality:
  * [V1Beta1 API docs](https://googleapis.dev/dotnet/Google.Cloud.Asset.V1Beta1/latest) (beta)
* [Google Cloud AutoML](https://cloud.google.com/automl/) - [API docs](https://googleapis.dev/dotnet/Google.AutoML.V1/latest) (GA)
* [Google BigQuery Data Transfer](https://cloud.google.com/bigquery/transfer/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.BigQuery.DataTransfer.V1/latest) (GA)
* [Google BigQuery](https://cloud.google.com/bigquery/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.BigQuery.V2/latest) (GA)
* [Google Cloud Bigtable](https://cloud.google.com/bigtable/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Bigtable.V2/latest) (GA)
  * Also the Bigtable admin API - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Bigtable.Admin.V2/latest) (GA)
* [Billing](https://cloud.google.com/billing/docs/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Billing.V1/latest) (GA)
* [Google Kubernetes Engine](https://cloud.google.com/kubernetes-engine/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Container.V1/latest) (GA)
* [Google Cloud Dataproc](https://cloud.google.com/dataproc/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Dataproc.V1/latest) (GA)
* [Google Cloud Datastore](https://cloud.google.com/datastore/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Datastore.V1/latest) (GA)
* [Google Cloud Debugger](https://cloud.google.com/debugger/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Debugger.V2/latest) (GA)
* [Google Cloud Container Analysis](https://cloud.google.com/container-registry/docs/container-analysis/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.DevTools.ContainerAnalysis.V1/latest) (GA)
  * This is an implementaiton of the [Grafeas](https://grafeas.io) API - [API docs](https://googleapis.dev/dotnet/Grafeas.V1/latest) (GA)
* Google Cloud Diagnostics for ASP.NET - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Diagnostics.AspNet/latest) (GA)
* Google Cloud Diagnostics for ASP.NET Core - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Diagnostics.AspNetCore/latest) (GA)
* [Dialogflow Enterprise Edition](https://cloud.google.com/dialogflow-enterprise/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Dialogflow.V2/latest) (GA)
* [Google Cloud Data Loss Prevention](https://cloud.google.com/dlp/)
  * [V2 API docs](https://googleapis.dev/dotnet/Google.Cloud.Dlp.V2/latest) (GA)
  * The Google.Cloud.Dlp.V2Beta1 package has now been deprecated, and is unlisted on nuget.org.
    Please update to Google.Cloud.Dlp.V2.
* [Google Cloud Firestore](https://cloud.google.com/firestore/): three packages are available, all GA:
  * [Google.Cloud.Firestore](https://googleapis.dev/dotnet/Google.Cloud.Firestore/latest): High-level client library for Google Cloud Firestore (recommended)
  * [Google.Cloud.Firestore.V1](https://googleapis.dev/dotnet/Google.Cloud.Firestore.V1/latest): Low-level access to Firestore API
  * [Google.Cloud.Firestore.Admin.V1](https://googleapis.dev/dotnet/Google.Cloud.Firestore.Admin.V1/latest): Admin API (e.g. for index management)
* [Google Cloud Key Management Service (KMS)](https://cloud.google.com/kms/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Kms.V1/latest) (GA)
* [Google Stackdriver Logging](https://cloud.google.com/logging/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Logging.V2/latest) (GA)
  * Integration with Log4Net is provided via [Google.Cloud.Logging.Log4Net](https://googleapis.dev/dotnet/Google.Cloud.Logging.Log4Net/latest) (GA)
  * Integration with NLog is provided via [Google.Cloud.Logging.NLog](https://googleapis.dev/dotnet/Google.Cloud.Logging.NLog/latest) (GA)
* [Google Cloud Natural Language](https://cloud.google.com/natural-language/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Language.V1/latest) (GA)
* [Stackdriver Monitoring](https://cloud.google.com/monitoring/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Monitoring.V3/latest) (GA)
* [Google OS Login](https://cloud.google.com/compute/docs/instances/managing-instance-access) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.OsLogin.V1/latest) (GA)
  * The [V1Beta API package](https://googleapis.dev/dotnet/Google.Cloud.OsLogin.V1Beta/latest) is also available (beta)
* [Google Cloud Pub/Sub](https://cloud.google.com/pubsub/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.PubSub.V1/latest) (GA)
* [Google Cloud Memorystore for Redis](https://cloud.google.com/memorystore/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Redis.V1/latest) (GA)
  * The [V1Beta1 API package](https://googleapis.dev/dotnet/Google.Cloud.Redis.V1Beta1/latest) is also available (beta)
* [Recommender](https://cloud.google.com/recommender/docs/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Recommender.V1/latest) (GA)
* [Google Cloud Scheduler](https://cloud.google.com/scheduler/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Scheduler.V1/latest) (GA)
* [Google Cloud Security Command Center](https://cloud.google.com/security-command-center/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.SecurityCenter.V1/latest) (GA)
  * The [V1P1Beta1 API package](https://googleapis.dev/dotnet/Google.Cloud.SecurityCenter.V1P1Beta1/latest) is also available (beta)
* [Google Cloud Spanner](https://cloud.google.com/spanner/): four packages are available, all GA:
  * [Google.Cloud.Spanner.Data](https://googleapis.dev/dotnet/Google.Cloud.Spanner.Data/latest): ADO.NET provider for Google Cloud Spanner (recommended)
  * [Google.Cloud.Spanner.V1](https://googleapis.dev/dotnet/Google.Cloud.Spanner.V1/latest): Low-level access to Spanner API
  * [Google.Cloud.Spanner.Admin.Database.V1](https://googleapis.dev/dotnet/Google.Cloud.Spanner.Admin.Database.V1/latest): Database administration API
  * [Google.Cloud.Spanner.Admin.Instance.V1](https://googleapis.dev/dotnet/Google.Cloud.Spanner.Admin.Instance.V1/latest): Instance administration API
* [Google Cloud Speech](https://cloud.google.com/speech/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Speech.V1/latest) (GA)
  * The [V1P1Beta1 API package](https://googleapis.dev/dotnet/Google.Cloud.Speech.V1P1Beta1/latest) is also available (beta)
* [Google Cloud Storage](https://cloud.google.com/storage/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Storage.V1/latest) (GA)
* [Google Cloud Tasks](https://cloud.google.com/tasks/) -[API docs](https://googleapis.dev/dotnet/Google.Cloud.Tasks.V2/latest) (GA)
* [Stackdriver Trace v1](https://cloud.google.com/trace/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Trace.V1/latest) (GA)
* [Stackdriver Trace v2](https://cloud.google.com/trace/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Trace.V2/latest) (GA)
* [Google Cloud Translate](https://cloud.google.com/translate/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Translate.V3/latest) (GA)
  * This uses the gRPC transport for access to the Translate V3 API, whereas Google.Cloud.Translation.V2 uses the HTTP/JSON transport for access to the Translate V2 API.
* [Google Cloud Translation](https://cloud.google.com/translate/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Translation.V2/latest) (GA)
* [Google Cloud Text-to-Speech](https://cloud.google.com/text-to-speech/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.TextToSpeech.V1/latest) (GA)
* [Google Cloud Video Intelligence](https://cloud.google.com/video-intelligence/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.VideoIntelligence.V1/latest) (GA)
* [Google Cloud Vision](https://cloud.google.com/vision/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.Vision.V1/latest) (GA)
  * Additionally, the following libraries are available for access to beta API functionality:
    * [Google.Cloud.Vision.V1P1Beta1](https://googleapis.dev/dotnet/Google.Cloud.Vision.V1P1Beta1/latest)
    * [Google.Cloud.Vision.V1P2Beta1](https://googleapis.dev/dotnet/Google.Cloud.Vision.V1P2Beta1/latest)

The following libraries are available at a [beta](#versioning) quality level:

* [Google BigQuery Storage](https://cloud.google.com/bigquery/docs/reference/storage/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.BigQuery.Storage.V1/latest) (beta)
* [Managed Service for Microsoft Active Directory](https://cloud.google.com/managed-microsoft-ad/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.ManagedIdentities.V1/latest) (beta)
* [Stackdriver Error Reporting](https://cloud.google.com/error-reporting/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.ErrorReporting.V1Beta1/latest) (beta)
* [Phishing Protection](https://cloud.google.com/phishing-protection/)- [API docs](https://googleapis.dev/dotnet/Google.Cloud.PhishingProtection.V1Beta1/latest) (beta)
* [reCAPTCHA Enterprise](https://cloud.google.com/recaptcha-enterprise/)- [API docs](https://googleapis.dev/dotnet/Google.Cloud.RecaptchaEnterprise.V1Beta1/latest) (beta)
* [Secret Manager](https://cloud.google.com/secret-manager) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.SecretManager.V1Beta1/latest) (beta)
* [Google Cloud Web Risk](https://cloud.google.com/web-risk/) - [API docs](https://googleapis.dev/dotnet/Google.Cloud.WebRisk.V1Beta1/latest) (Beta)

See the [API documentation](https://googleapis.dev/dotnet/latest) for details of the status
of each library.

If you need support for other Google APIs, check out the
[Google .NET API Client library](https://github.com/google/google-api-dotnet-client)

## Example Applications

* [getting-started-dotnet](https://github.com/googleapis/getting-started-dotnet/) -
  A [quickstart and tutorial](https://cloud.google.com/dotnet/) that demonstrates how to build a complete web 
  application using Cloud Datastore, Cloud Storage, and Cloud Pub/Sub and deploy it to Google Compute Engine.

## Specifying a Project ID

Most Google Cloud Libraries for .NET require a project ID. If you
don't remember yours (or haven't created a project yet), navigate to
the [Google Developers Console](https://console.developers.google.com/project) to view
your project ID (or create a new project and then get the ID). Once
done, record the value and make sure to pass it as a parameter to
the methods that require it.

## Authentication

Every API call needs to be authenticated. In order to successfully
make a call, first ensure that the necessary [Google Cloud
APIs](https://console.developers.google.com/apis/library/) are enabled for your project and that
you've downloaded the right set of keys (if it applies to you) as
explained in the [authentication
document](https://github.com/googleapis/google-cloud-common/blob/master/authentication/readme.md#authentication).

Next, choose a method for authenticating API requests from within your project:

1. When using `google-cloud-dotnet` libraries from within Compute/App Engine, no additional authentication steps are necessary.
2. When using `google-cloud-dotnet` libraries elsewhere, you can do one of the following:
    * Define the environment variable GOOGLE_APPLICATION_CREDENTIALS to be the location of the key.  For example:

      ```
      set GOOGLE_APPLICATION_CREDENTIALS=/path/to/my/key.json
      ``` 
    * If running locally for development/testing, you can authenticate using the [Google Cloud SDK](https://cloud.google.com/sdk/).
      Download the SDK if you haven't already, then login by running the following in the command line:

      ```
      gcloud auth application-default login
      ```

## Supported platforms

See the [Supported Platforms
documentation](https://googleapis.github.io/google-cloud-dotnet/docs/guides/platforms.html)
for details on where the Google Cloud Libraries for .NET are
supported.

## Versioning

The Google Cloud Client Libraries for .NET follow [Semantic Versioning](http://semver.org/).

The version number in the package *name* (and .NET namespace)
represents the version of the underlying API; the version number for
the package itself indicates the status of the client library, according to
the following quality levels:

**GA**: Libraries defined at a GA (General Availability) quality level are
expected to be stable: breaking API changes will not be made without a new major
release.

**Beta**: Libraries defined at a Beta quality level are expected to
be stable and working, but the API surface is still under active
development. We encourage you to experiment with these libraries, but
expect breaking changes in future versions. There may still be
issues, but we have a fairly high degree of confidence.

## License

Apache 2.0 - See [LICENSE](./LICENSE) for more information.
