// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Connect.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tron.Protocol.Messages {

  /// <summary>Holder for reflection information generated from Connect.proto</summary>
  public static partial class ConnectReflection {

    #region Descriptor
    /// <summary>File descriptor for Connect.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConnectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1Db25uZWN0LnByb3RvEhZ0cm9uLnByb3RvY29sLm1lc3NhZ2VzGgxDb21t",
            "b24ucHJvdG8iZAoHUmVxdWVzdBIMCgRuYW1lGAEgASgJEhsKE2Nvbm5lY3Rp",
            "b25fZ3JvdXBfaWQYAiABKAkSLgoHcHJpdmFjeRgDIAEoDjIdLnRyb24ucHJv",
            "dG9jb2wuY29tbW9uLlByaXZhY3kiswEKCFJlc3BvbnNlEioKBWNvbG9yGAEg",
            "ASgLMhsudHJvbi5wcm90b2NvbC5jb21tb24uQ29sb3ISGwoTY29ubmVjdGlv",
            "bl9ncm91cF9pZBgCIAEoCRIvCghzZXR0aW5ncxgDIAEoCzIdLnRyb24ucHJv",
            "dG9jb2wuY29tbW9uLlNldHRpbmcSLQoHcGxheWVycxgEIAMoCzIcLnRyb24u",
            "cHJvdG9jb2wuY29tbW9uLlBsYXllcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tron.Protocol.Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tron.Protocol.Messages.Request), global::Tron.Protocol.Messages.Request.Parser, new[]{ "Name", "ConnectionGroupId", "Privacy" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tron.Protocol.Messages.Response), global::Tron.Protocol.Messages.Response.Parser, new[]{ "Color", "ConnectionGroupId", "Settings", "Players" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tron.Protocol.Messages.ConnectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      name_ = other.name_;
      connectionGroupId_ = other.connectionGroupId_;
      privacy_ = other.privacy_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "connection_group_id" field.</summary>
    public const int ConnectionGroupIdFieldNumber = 2;
    private string connectionGroupId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ConnectionGroupId {
      get { return connectionGroupId_; }
      set {
        connectionGroupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "privacy" field.</summary>
    public const int PrivacyFieldNumber = 3;
    private global::Tron.Protocol.Common.Privacy privacy_ = global::Tron.Protocol.Common.Privacy.Public;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Common.Privacy Privacy {
      get { return privacy_; }
      set {
        privacy_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ConnectionGroupId != other.ConnectionGroupId) return false;
      if (Privacy != other.Privacy) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ConnectionGroupId.Length != 0) hash ^= ConnectionGroupId.GetHashCode();
      if (Privacy != global::Tron.Protocol.Common.Privacy.Public) hash ^= Privacy.GetHashCode();
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
      if (ConnectionGroupId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ConnectionGroupId);
      }
      if (Privacy != global::Tron.Protocol.Common.Privacy.Public) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Privacy);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ConnectionGroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConnectionGroupId);
      }
      if (Privacy != global::Tron.Protocol.Common.Privacy.Public) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Privacy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ConnectionGroupId.Length != 0) {
        ConnectionGroupId = other.ConnectionGroupId;
      }
      if (other.Privacy != global::Tron.Protocol.Common.Privacy.Public) {
        Privacy = other.Privacy;
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
            ConnectionGroupId = input.ReadString();
            break;
          }
          case 24: {
            Privacy = (global::Tron.Protocol.Common.Privacy) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tron.Protocol.Messages.ConnectReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      color_ = other.color_ != null ? other.color_.Clone() : null;
      connectionGroupId_ = other.connectionGroupId_;
      settings_ = other.settings_ != null ? other.settings_.Clone() : null;
      players_ = other.players_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
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

    /// <summary>Field number for the "connection_group_id" field.</summary>
    public const int ConnectionGroupIdFieldNumber = 2;
    private string connectionGroupId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ConnectionGroupId {
      get { return connectionGroupId_; }
      set {
        connectionGroupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "settings" field.</summary>
    public const int SettingsFieldNumber = 3;
    private global::Tron.Protocol.Common.Setting settings_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Common.Setting Settings {
      get { return settings_; }
      set {
        settings_ = value;
      }
    }

    /// <summary>Field number for the "players" field.</summary>
    public const int PlayersFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Tron.Protocol.Common.Player> _repeated_players_codec
        = pb::FieldCodec.ForMessage(34, global::Tron.Protocol.Common.Player.Parser);
    private readonly pbc::RepeatedField<global::Tron.Protocol.Common.Player> players_ = new pbc::RepeatedField<global::Tron.Protocol.Common.Player>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tron.Protocol.Common.Player> Players {
      get { return players_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Color, other.Color)) return false;
      if (ConnectionGroupId != other.ConnectionGroupId) return false;
      if (!object.Equals(Settings, other.Settings)) return false;
      if(!players_.Equals(other.players_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (color_ != null) hash ^= Color.GetHashCode();
      if (ConnectionGroupId.Length != 0) hash ^= ConnectionGroupId.GetHashCode();
      if (settings_ != null) hash ^= Settings.GetHashCode();
      hash ^= players_.GetHashCode();
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
      if (ConnectionGroupId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ConnectionGroupId);
      }
      if (settings_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Settings);
      }
      players_.WriteTo(output, _repeated_players_codec);
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
      if (ConnectionGroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConnectionGroupId);
      }
      if (settings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
      }
      size += players_.CalculateSize(_repeated_players_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.color_ != null) {
        if (color_ == null) {
          Color = new global::Tron.Protocol.Common.Color();
        }
        Color.MergeFrom(other.Color);
      }
      if (other.ConnectionGroupId.Length != 0) {
        ConnectionGroupId = other.ConnectionGroupId;
      }
      if (other.settings_ != null) {
        if (settings_ == null) {
          Settings = new global::Tron.Protocol.Common.Setting();
        }
        Settings.MergeFrom(other.Settings);
      }
      players_.Add(other.players_);
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
            ConnectionGroupId = input.ReadString();
            break;
          }
          case 26: {
            if (settings_ == null) {
              Settings = new global::Tron.Protocol.Common.Setting();
            }
            input.ReadMessage(Settings);
            break;
          }
          case 34: {
            players_.AddEntriesFrom(input, _repeated_players_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code