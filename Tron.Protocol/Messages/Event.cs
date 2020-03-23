// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Event.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tron.Protocol.Messages {

  /// <summary>Holder for reflection information generated from Event.proto</summary>
  public static partial class EventReflection {

    #region Descriptor
    /// <summary>File descriptor for Event.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtFdmVudC5wcm90bxIWdHJvbi5wcm90b2NvbC5tZXNzYWdlcxoMQ29tbW9u",
            "LnByb3RvIn8KC1BsYXllckV2ZW50EjMKBWNvbG9yGAEgASgLMiQudHJvbi5w",
            "cm90b2NvbC5tZXNzYWdlcy5jb21tb24uQ29sb3ISOwoJZGlyZWN0aW9uGAIg",
            "ASgOMigudHJvbi5wcm90b2NvbC5tZXNzYWdlcy5jb21tb24uRGlyZWN0aW9u",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tron.Protocol.Messages.Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tron.Protocol.Messages.PlayerEvent), global::Tron.Protocol.Messages.PlayerEvent.Parser, new[]{ "Color", "Direction" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerEvent : pb::IMessage<PlayerEvent> {
    private static readonly pb::MessageParser<PlayerEvent> _parser = new pb::MessageParser<PlayerEvent>(() => new PlayerEvent());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PlayerEvent> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tron.Protocol.Messages.EventReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerEvent() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerEvent(PlayerEvent other) : this() {
      color_ = other.color_ != null ? other.color_.Clone() : null;
      direction_ = other.direction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlayerEvent Clone() {
      return new PlayerEvent(this);
    }

    /// <summary>Field number for the "color" field.</summary>
    public const int ColorFieldNumber = 1;
    private global::Tron.Protocol.Messages.Common.Color color_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Messages.Common.Color Color {
      get { return color_; }
      set {
        color_ = value;
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 2;
    private global::Tron.Protocol.Messages.Common.Direction direction_ = global::Tron.Protocol.Messages.Common.Direction.Up;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tron.Protocol.Messages.Common.Direction Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PlayerEvent);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PlayerEvent other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Color, other.Color)) return false;
      if (Direction != other.Direction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (color_ != null) hash ^= Color.GetHashCode();
      if (Direction != global::Tron.Protocol.Messages.Common.Direction.Up) hash ^= Direction.GetHashCode();
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
      if (Direction != global::Tron.Protocol.Messages.Common.Direction.Up) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Direction);
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
      if (Direction != global::Tron.Protocol.Messages.Common.Direction.Up) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PlayerEvent other) {
      if (other == null) {
        return;
      }
      if (other.color_ != null) {
        if (color_ == null) {
          Color = new global::Tron.Protocol.Messages.Common.Color();
        }
        Color.MergeFrom(other.Color);
      }
      if (other.Direction != global::Tron.Protocol.Messages.Common.Direction.Up) {
        Direction = other.Direction;
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
              Color = new global::Tron.Protocol.Messages.Common.Color();
            }
            input.ReadMessage(Color);
            break;
          }
          case 16: {
            Direction = (global::Tron.Protocol.Messages.Common.Direction) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
