// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Configure.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tron.Protocol.Messages {

  /// <summary>Holder for reflection information generated from Configure.proto</summary>
  public static partial class ConfigureReflection {

    #region Descriptor
    /// <summary>File descriptor for Configure.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConfigureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9Db25maWd1cmUucHJvdG8SFnRyb24ucHJvdG9jb2wubWVzc2FnZXMaDENv",
            "bW1vbi5wcm90byJoCglDb25maWd1cmUSKgoFY29sb3IYASABKAsyGy50cm9u",
            "LnByb3RvY29sLmNvbW1vbi5Db2xvchIvCghzZXR0aW5ncxgCIAEoCzIdLnRy",
            "b24ucHJvdG9jb2wuY29tbW9uLlNldHRpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tron.Protocol.Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tron.Protocol.Messages.Configure), global::Tron.Protocol.Messages.Configure.Parser, new[]{ "Color", "Settings" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Configure : pb::IMessage<Configure> {
    private static readonly pb::MessageParser<Configure> _parser = new pb::MessageParser<Configure>(() => new Configure());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Configure> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tron.Protocol.Messages.ConfigureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Configure() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Configure(Configure other) : this() {
      color_ = other.color_ != null ? other.color_.Clone() : null;
      settings_ = other.settings_ != null ? other.settings_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Configure Clone() {
      return new Configure(this);
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 1;
    private global::Tron.Protocol.Common.Color color_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Common.Color Color {
      get { return color_; }
      set {
        color_ = value;
      }
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 2;
    private global::Tron.Protocol.Common.Setting settings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Common.Setting Settings {
      get { return settings_; }
      set {
        settings_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Configure);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Configure other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Color, other.Color)) return false;
      if (!object.Equals(Settings, other.Settings)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (color_ != null) hash ^= Color.GetHashCode();
      if (settings_ != null) hash ^= Settings.GetHashCode();
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
      if (color_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Color);
      }
      if (settings_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Settings);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (color_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Color);
      }
      if (settings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Configure other) {
      if (other == null) {
        return;
      }
      if (other.color_ != null) {
        if (color_ == null) {
          Color = new global::Tron.Protocol.Common.Color();
        }
        Color.MergeFrom(other.Color);
      }
      if (other.settings_ != null) {
        if (settings_ == null) {
          Settings = new global::Tron.Protocol.Common.Setting();
        }
        Settings.MergeFrom(other.Settings);
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
            if (color_ == null) {
              Color = new global::Tron.Protocol.Common.Color();
            }
            input.ReadMessage(Color);
            break;
          }
          case 18: {
            if (settings_ == null) {
              Settings = new global::Tron.Protocol.Common.Setting();
            }
            input.ReadMessage(Settings);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code