// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gclv = Google.Cloud.Logging.V2;
using sys = System;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Resource name for the <c>Metric</c> resource.</summary>
    public sealed partial class MetricName : gax::IResourceName, sys::IEquatable<MetricName>
    {
        /// <summary>The possible contents of <see cref="MetricName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/metrics/{metric}</c>.</summary>
            ProjectMetric = 1
        }

        private static gax::PathTemplate s_projectMetric = new gax::PathTemplate("projects/{project}/metrics/{metric}");

        /// <summary>Creates a <see cref="MetricName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MetricName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MetricName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MetricName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MetricName"/> with the pattern <c>projects/{project}/metrics/{metric}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MetricName"/> constructed from the provided ids.</returns>
        public static MetricName FromProjectMetric(string projectId, string metricId) =>
            new MetricName(ResourceNameType.ProjectMetric, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), metricId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricId, nameof(metricId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </returns>
        public static string Format(string projectId, string metricId) => FormatProjectMetric(projectId, metricId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MetricName"/> with pattern
        /// <c>projects/{project}/metrics/{metric}</c>.
        /// </returns>
        public static string FormatProjectMetric(string projectId, string metricId) =>
            s_projectMetric.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metricId, nameof(metricId)));

        /// <summary>Parses the given resource name string into a new <see cref="MetricName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MetricName"/> if successful.</returns>
        public static MetricName Parse(string metricName) => Parse(metricName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MetricName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MetricName"/> if successful.</returns>
        public static MetricName Parse(string metricName, bool allowUnparsed) =>
            TryParse(metricName, allowUnparsed, out MetricName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="metricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricName, out MetricName result) => TryParse(metricName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MetricName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/metrics/{metric}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="metricName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MetricName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string metricName, bool allowUnparsed, out MetricName result)
        {
            gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName));
            gax::TemplatedResourceName resourceName;
            if (s_projectMetric.TryParseName(metricName, out resourceName))
            {
                result = FromProjectMetric(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(metricName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MetricName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string metricId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MetricId = metricId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MetricName"/> class from the component parts of pattern
        /// <c>projects/{project}/metrics/{metric}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metricId">The <c>Metric</c> ID. Must not be <c>null</c> or empty.</param>
        public MetricName(string projectId, string metricId) : this(ResourceNameType.ProjectMetric, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), metricId: gax::GaxPreconditions.CheckNotNullOrEmpty(metricId, nameof(metricId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Metric</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MetricId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectMetric: return s_projectMetric.Expand(ProjectId, MetricId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MetricName);

        /// <inheritdoc/>
        public bool Equals(MetricName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MetricName a, MetricName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MetricName a, MetricName b) => !(a == b);
    }

    public partial class LogMetric
    {
        /// <summary>
        /// <see cref="gclv::MetricName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gclv::MetricName MetricName
        {
            get => string.IsNullOrEmpty(Name) ? null : gclv::MetricName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLogMetricsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLogMetricRequest
    {
        /// <summary>
        /// <see cref="gclv::MetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public gclv::MetricName MetricNameAsMetricName
        {
            get => string.IsNullOrEmpty(MetricName) ? null : gclv::MetricName.Parse(MetricName, allowUnparsed: true);
            set => MetricName = value?.ToString() ?? "";
        }
    }

    public partial class CreateLogMetricRequest
    {
        /// <summary><see cref="MetricName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public MetricName ParentAsMetricName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MetricName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class UpdateLogMetricRequest
    {
        /// <summary>
        /// <see cref="gclv::MetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public gclv::MetricName MetricNameAsMetricName
        {
            get => string.IsNullOrEmpty(MetricName) ? null : gclv::MetricName.Parse(MetricName, allowUnparsed: true);
            set => MetricName = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLogMetricRequest
    {
        /// <summary>
        /// <see cref="gclv::MetricName"/>-typed view over the <see cref="MetricName"/> resource name property.
        /// </summary>
        public gclv::MetricName MetricNameAsMetricName
        {
            get => string.IsNullOrEmpty(MetricName) ? null : gclv::MetricName.Parse(MetricName, allowUnparsed: true);
            set => MetricName = value?.ToString() ?? "";
        }
    }
}
