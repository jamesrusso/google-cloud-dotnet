// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/model.proto</summary>
  public static partial class ModelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJnb29nbGUvY2xvdWQvYXV0b21sL3YxL21vZGVsLnByb3RvEhZnb29nbGUu",
            "Y2xvdWQuYXV0b21sLnYxGihnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RyYW5z",
            "bGF0aW9uLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3Rv",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpEECgVNb2RlbBJWChp0",
            "cmFuc2xhdGlvbl9tb2RlbF9tZXRhZGF0YRgPIAEoCzIwLmdvb2dsZS5jbG91",
            "ZC5hdXRvbWwudjEuVHJhbnNsYXRpb25Nb2RlbE1ldGFkYXRhSAASDAoEbmFt",
            "ZRgBIAEoCRIUCgxkaXNwbGF5X25hbWUYAiABKAkSEgoKZGF0YXNldF9pZBgD",
            "IAEoCRIvCgtjcmVhdGVfdGltZRgHIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXASLwoLdXBkYXRlX3RpbWUYCyABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wEkcKEGRlcGxveW1lbnRfc3RhdGUYCCABKA4yLS5nb29n",
            "bGUuY2xvdWQuYXV0b21sLnYxLk1vZGVsLkRlcGxveW1lbnRTdGF0ZRI5CgZs",
            "YWJlbHMYIiADKAsyKS5nb29nbGUuY2xvdWQuYXV0b21sLnYxLk1vZGVsLkxh",
            "YmVsc0VudHJ5Gi0KC0xhYmVsc0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1",
            "ZRgCIAEoCToCOAEiUQoPRGVwbG95bWVudFN0YXRlEiAKHERFUExPWU1FTlRf",
            "U1RBVEVfVU5TUEVDSUZJRUQQABIMCghERVBMT1lFRBABEg4KClVOREVQTE9Z",
            "RUQQAkIQCg5tb2RlbF9tZXRhZGF0YUKqAQoaY29tLmdvb2dsZS5jbG91ZC5h",
            "dXRvbWwudjFQAVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9jbG91ZC9hdXRvbWwvdjE7YXV0b21sqgIWR29vZ2xlLkNsb3VkLkF1",
            "dG9NTC5WMcoCFkdvb2dsZVxDbG91ZFxBdXRvTUxcVjHqAhlHb29nbGU6OkNs",
            "b3VkOjpBdXRvTUw6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.AutoML.V1.TranslationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.Model), global::Google.Cloud.AutoML.V1.Model.Parser, new[]{ "TranslationModelMetadata", "Name", "DisplayName", "DatasetId", "CreateTime", "UpdateTime", "DeploymentState", "Labels" }, new[]{ "ModelMetadata" }, new[]{ typeof(global::Google.Cloud.AutoML.V1.Model.Types.DeploymentState) }, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// API proto representing a trained machine learning model.
  /// </summary>
  public sealed partial class Model : pb::IMessage<Model> {
    private static readonly pb::MessageParser<Model> _parser = new pb::MessageParser<Model>(() => new Model());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Model> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.ModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Model() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Model(Model other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      datasetId_ = other.datasetId_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      updateTime_ = other.updateTime_ != null ? other.updateTime_.Clone() : null;
      deploymentState_ = other.deploymentState_;
      labels_ = other.labels_.Clone();
      switch (other.ModelMetadataCase) {
        case ModelMetadataOneofCase.TranslationModelMetadata:
          TranslationModelMetadata = other.TranslationModelMetadata.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Model Clone() {
      return new Model(this);
    }

    /// <summary>Field number for the "translation_model_metadata" field.</summary>
    public const int TranslationModelMetadataFieldNumber = 15;
    /// <summary>
    /// Metadata for translation models.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.TranslationModelMetadata TranslationModelMetadata {
      get { return modelMetadataCase_ == ModelMetadataOneofCase.TranslationModelMetadata ? (global::Google.Cloud.AutoML.V1.TranslationModelMetadata) modelMetadata_ : null; }
      set {
        modelMetadata_ = value;
        modelMetadataCase_ = value == null ? ModelMetadataOneofCase.None : ModelMetadataOneofCase.TranslationModelMetadata;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Resource name of the model.
    /// Format: `projects/{project_id}/locations/{location_id}/models/{model_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The name of the model to show in the interface. The name can be
    /// up to 32 characters long and can consist only of ASCII Latin letters A-Z
    /// and a-z, underscores
    /// (_), and ASCII digits 0-9. It must start with a letter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "dataset_id" field.</summary>
    public const int DatasetIdFieldNumber = 3;
    private string datasetId_ = "";
    /// <summary>
    /// Required. The resource ID of the dataset used to create the model. The dataset must
    /// come from the same ancestor project and location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DatasetId {
      get { return datasetId_; }
      set {
        datasetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp when the model training finished  and can be used for prediction.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "update_time" field.</summary>
    public const int UpdateTimeFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Timestamp updateTime_;
    /// <summary>
    /// Output only. Timestamp when this model was last updated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp UpdateTime {
      get { return updateTime_; }
      set {
        updateTime_ = value;
      }
    }

    /// <summary>Field number for the "deployment_state" field.</summary>
    public const int DeploymentStateFieldNumber = 8;
    private global::Google.Cloud.AutoML.V1.Model.Types.DeploymentState deploymentState_ = 0;
    /// <summary>
    /// Output only. Deployment state of the model. A model can only serve
    /// prediction requests after it gets deployed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.AutoML.V1.Model.Types.DeploymentState DeploymentState {
      get { return deploymentState_; }
      set {
        deploymentState_ = value;
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 34;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 274);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Optional. The labels with user-defined metadata to organize your model.
    ///
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// Label values are optional. Label keys must start with a letter.
    ///
    /// See https://goo.gl/xmQnxf for more information on and examples of labels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    private object modelMetadata_;
    /// <summary>Enum of possible cases for the "model_metadata" oneof.</summary>
    public enum ModelMetadataOneofCase {
      None = 0,
      TranslationModelMetadata = 15,
    }
    private ModelMetadataOneofCase modelMetadataCase_ = ModelMetadataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelMetadataOneofCase ModelMetadataCase {
      get { return modelMetadataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearModelMetadata() {
      modelMetadataCase_ = ModelMetadataOneofCase.None;
      modelMetadata_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Model);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Model other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TranslationModelMetadata, other.TranslationModelMetadata)) return false;
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (DatasetId != other.DatasetId) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(UpdateTime, other.UpdateTime)) return false;
      if (DeploymentState != other.DeploymentState) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (ModelMetadataCase != other.ModelMetadataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (modelMetadataCase_ == ModelMetadataOneofCase.TranslationModelMetadata) hash ^= TranslationModelMetadata.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (DatasetId.Length != 0) hash ^= DatasetId.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (updateTime_ != null) hash ^= UpdateTime.GetHashCode();
      if (DeploymentState != 0) hash ^= DeploymentState.GetHashCode();
      hash ^= Labels.GetHashCode();
      hash ^= (int) modelMetadataCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (DatasetId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DatasetId);
      }
      if (createTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(CreateTime);
      }
      if (DeploymentState != 0) {
        output.WriteRawTag(64);
        output.WriteEnum((int) DeploymentState);
      }
      if (updateTime_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(UpdateTime);
      }
      if (modelMetadataCase_ == ModelMetadataOneofCase.TranslationModelMetadata) {
        output.WriteRawTag(122);
        output.WriteMessage(TranslationModelMetadata);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (modelMetadataCase_ == ModelMetadataOneofCase.TranslationModelMetadata) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TranslationModelMetadata);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (DatasetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DatasetId);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (updateTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UpdateTime);
      }
      if (DeploymentState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DeploymentState);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Model other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.DatasetId.Length != 0) {
        DatasetId = other.DatasetId;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.updateTime_ != null) {
        if (updateTime_ == null) {
          UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        UpdateTime.MergeFrom(other.UpdateTime);
      }
      if (other.DeploymentState != 0) {
        DeploymentState = other.DeploymentState;
      }
      labels_.Add(other.labels_);
      switch (other.ModelMetadataCase) {
        case ModelMetadataOneofCase.TranslationModelMetadata:
          if (TranslationModelMetadata == null) {
            TranslationModelMetadata = new global::Google.Cloud.AutoML.V1.TranslationModelMetadata();
          }
          TranslationModelMetadata.MergeFrom(other.TranslationModelMetadata);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            DatasetId = input.ReadString();
            break;
          }
          case 58: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 64: {
            DeploymentState = (global::Google.Cloud.AutoML.V1.Model.Types.DeploymentState) input.ReadEnum();
            break;
          }
          case 90: {
            if (updateTime_ == null) {
              UpdateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(UpdateTime);
            break;
          }
          case 122: {
            global::Google.Cloud.AutoML.V1.TranslationModelMetadata subBuilder = new global::Google.Cloud.AutoML.V1.TranslationModelMetadata();
            if (modelMetadataCase_ == ModelMetadataOneofCase.TranslationModelMetadata) {
              subBuilder.MergeFrom(TranslationModelMetadata);
            }
            input.ReadMessage(subBuilder);
            TranslationModelMetadata = subBuilder;
            break;
          }
          case 274: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Model message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Deployment state of the model.
      /// </summary>
      public enum DeploymentState {
        /// <summary>
        /// Should not be used, an un-set enum has this value by default.
        /// </summary>
        [pbr::OriginalName("DEPLOYMENT_STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Model is deployed.
        /// </summary>
        [pbr::OriginalName("DEPLOYED")] Deployed = 1,
        /// <summary>
        /// Model is not deployed.
        /// </summary>
        [pbr::OriginalName("UNDEPLOYED")] Undeployed = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
