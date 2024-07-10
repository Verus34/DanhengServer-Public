// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AlleyPlacingShip.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from AlleyPlacingShip.proto</summary>
  public static partial class AlleyPlacingShipReflection {

    #region Descriptor
    /// <summary>File descriptor for AlleyPlacingShip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AlleyPlacingShipReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZBbGxleVBsYWNpbmdTaGlwLnByb3RvGhFMT0JLR01QQkZHRi5wcm90byJP",
            "ChBBbGxleVBsYWNpbmdTaGlwEhkKEVNoaXBJZEZpZWxkTnVtYmVyGAUgASgN",
            "EiAKCmdvb2RzX2xpc3QYBCADKAsyDC5MT0JLR01QQkZHRkIeqgIbRWdnTGlu",
            "ay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.LOBKGMPBFGFReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.AlleyPlacingShip), global::EggLink.DanhengServer.Proto.AlleyPlacingShip.Parser, new[]{ "ShipIdFieldNumber", "GoodsList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AlleyPlacingShip : pb::IMessage<AlleyPlacingShip>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AlleyPlacingShip> _parser = new pb::MessageParser<AlleyPlacingShip>(() => new AlleyPlacingShip());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AlleyPlacingShip> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.AlleyPlacingShipReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingShip() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingShip(AlleyPlacingShip other) : this() {
      shipIdFieldNumber_ = other.shipIdFieldNumber_;
      goodsList_ = other.goodsList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AlleyPlacingShip Clone() {
      return new AlleyPlacingShip(this);
    }

    /// <summary>Field number for the "ShipIdFieldNumber" field.</summary>
    public const int ShipIdFieldNumberFieldNumber = 5;
    private uint shipIdFieldNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShipIdFieldNumber {
      get { return shipIdFieldNumber_; }
      set {
        shipIdFieldNumber_ = value;
      }
    }

    /// <summary>Field number for the "goods_list" field.</summary>
    public const int GoodsListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.LOBKGMPBFGF> _repeated_goodsList_codec
        = pb::FieldCodec.ForMessage(34, global::EggLink.DanhengServer.Proto.LOBKGMPBFGF.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LOBKGMPBFGF> goodsList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LOBKGMPBFGF>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.LOBKGMPBFGF> GoodsList {
      get { return goodsList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AlleyPlacingShip);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AlleyPlacingShip other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShipIdFieldNumber != other.ShipIdFieldNumber) return false;
      if(!goodsList_.Equals(other.goodsList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShipIdFieldNumber != 0) hash ^= ShipIdFieldNumber.GetHashCode();
      hash ^= goodsList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      goodsList_.WriteTo(output, _repeated_goodsList_codec);
      if (ShipIdFieldNumber != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ShipIdFieldNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
      if (ShipIdFieldNumber != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ShipIdFieldNumber);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ShipIdFieldNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShipIdFieldNumber);
      }
      size += goodsList_.CalculateSize(_repeated_goodsList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AlleyPlacingShip other) {
      if (other == null) {
        return;
      }
      if (other.ShipIdFieldNumber != 0) {
        ShipIdFieldNumber = other.ShipIdFieldNumber;
      }
      goodsList_.Add(other.goodsList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 34: {
            goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
            break;
          }
          case 40: {
            ShipIdFieldNumber = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 34: {
            goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
            break;
          }
          case 40: {
            ShipIdFieldNumber = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
