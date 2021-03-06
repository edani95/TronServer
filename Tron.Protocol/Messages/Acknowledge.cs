// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Acknowledge.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tron.Protocol.Messages {

  /// <summary>Holder for reflection information generated from Acknowledge.proto</summary>
  public static partial class AcknowledgeReflection {

    #region Descriptor
    /// <summary>File descriptor for Acknowledge.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AcknowledgeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBY2tub3dsZWRnZS5wcm90bxIWdHJvbi5wcm90b2NvbC5tZXNzYWdlcxoM",
            "Q29tbW9uLnByb3RvIoABCgpDb25uZWN0aW9uEjUKBnBsYXllchgBIAEoCzIl",
            "LnRyb24ucHJvdG9jb2wubWVzc2FnZXMuY29tbW9uLlBsYXllchI7CgZhY3Rp",
            "b24YAiABKA4yKy50cm9uLnByb3RvY29sLm1lc3NhZ2VzLmNvbW1vbi5Db25u",
            "ZWN0U3RhdGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tron.Protocol.Messages.Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tron.Protocol.Messages.Connection), global::Tron.Protocol.Messages.Connection.Parser, new[]{ "Player", "Action" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Connection : pb::IMessage<Connection> {
    private static readonly pb::MessageParser<Connection> _parser = new pb::MessageParser<Connection>(() => new Connection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Connection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tron.Protocol.Messages.AcknowledgeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Connection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Connection(Connection other) : this() {
      player_ = other.player_ != null ? other.player_.Clone() : null;
      action_ = other.action_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Connection Clone() {
      return new Connection(this);
    }

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 1;
    private global::Tron.Protocol.Messages.Common.Player player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Messages.Common.Player Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    /// <summary>Field number for the "action" field.</summary>
    public const int ActionFieldNumber = 2;
    private global::Tron.Protocol.Messages.Common.ConnectState action_ = global::Tron.Protocol.Messages.Common.ConnectState.Connect;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Messages.Common.ConnectState Action {
      get { return action_; }
      set {
        action_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Connection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Connection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Player, other.Player)) return false;
      if (Action != other.Action) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (player_ != null) hash ^= Player.GetHashCode();
      if (Action != global::Tron.Protocol.Messages.Common.ConnectState.Connect) hash ^= Action.GetHashCode();
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
      if (player_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Player);
      }
      if (Action != global::Tron.Protocol.Messages.Common.ConnectState.Connect) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Action);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (Action != global::Tron.Protocol.Messages.Common.ConnectState.Connect) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Action);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Connection other) {
      if (other == null) {
        return;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          Player = new global::Tron.Protocol.Messages.Common.Player();
        }
        Player.MergeFrom(other.Player);
      }
      if (other.Action != global::Tron.Protocol.Messages.Common.ConnectState.Connect) {
        Action = other.Action;
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
            if (player_ == null) {
              Player = new global::Tron.Protocol.Messages.Common.Player();
            }
            input.ReadMessage(Player);
            break;
          }
          case 16: {
            Action = (global::Tron.Protocol.Messages.Common.ConnectState) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
