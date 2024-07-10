// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BuyGoodsCsReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from BuyGoodsCsReq.proto</summary>
  public static partial class BuyGoodsCsReqReflection {

    #region Descriptor
    /// <summary>File descriptor for BuyGoodsCsReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuyGoodsCsReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNCdXlHb29kc0NzUmVxLnByb3RvImoKDUJ1eUdvb2RzQ3NSZXESDwoHc2hv",
            "cF9pZBgNIAEoDRISCgptb25zdGVyX2lkGAUgASgNEhEKCWdvb2RzX251bRgE",
            "IAEoDRIPCgdpdGVtX2lkGAMgASgNEhAKCGdvb2RzX2lkGAYgASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.BuyGoodsCsReq), global::EggLink.DanhengServer.Proto.BuyGoodsCsReq.Parser, new[]{ "ShopId", "MonsterId", "GoodsNum", "ItemId", "GoodsId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BuyGoodsCsReq : pb::IMessage<BuyGoodsCsReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BuyGoodsCsReq> _parser = new pb::MessageParser<BuyGoodsCsReq>(() => new BuyGoodsCsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BuyGoodsCsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.BuyGoodsCsReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuyGoodsCsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuyGoodsCsReq(BuyGoodsCsReq other) : this() {
      shopId_ = other.shopId_;
      monsterId_ = other.monsterId_;
      goodsNum_ = other.goodsNum_;
      itemId_ = other.itemId_;
      goodsId_ = other.goodsId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BuyGoodsCsReq Clone() {
      return new BuyGoodsCsReq(this);
    }

    /// <summary>Field number for the "shop_id" field.</summary>
    public const int ShopIdFieldNumber = 13;
    private uint shopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopId {
      get { return shopId_; }
      set {
        shopId_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 5;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "goods_num" field.</summary>
    public const int GoodsNumFieldNumber = 4;
    private uint goodsNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GoodsNum {
      get { return goodsNum_; }
      set {
        goodsNum_ = value;
      }
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 3;
    private uint itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "goods_id" field.</summary>
    public const int GoodsIdFieldNumber = 6;
    private uint goodsId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GoodsId {
      get { return goodsId_; }
      set {
        goodsId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BuyGoodsCsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BuyGoodsCsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShopId != other.ShopId) return false;
      if (MonsterId != other.MonsterId) return false;
      if (GoodsNum != other.GoodsNum) return false;
      if (ItemId != other.ItemId) return false;
      if (GoodsId != other.GoodsId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShopId != 0) hash ^= ShopId.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (GoodsNum != 0) hash ^= GoodsNum.GetHashCode();
      if (ItemId != 0) hash ^= ItemId.GetHashCode();
      if (GoodsId != 0) hash ^= GoodsId.GetHashCode();
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
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (GoodsNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GoodsNum);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MonsterId);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GoodsId);
      }
      if (ShopId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ShopId);
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
      if (ItemId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ItemId);
      }
      if (GoodsNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(GoodsNum);
      }
      if (MonsterId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MonsterId);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GoodsId);
      }
      if (ShopId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ShopId);
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
      if (ShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopId);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (GoodsNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsNum);
      }
      if (ItemId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ItemId);
      }
      if (GoodsId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BuyGoodsCsReq other) {
      if (other == null) {
        return;
      }
      if (other.ShopId != 0) {
        ShopId = other.ShopId;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.GoodsNum != 0) {
        GoodsNum = other.GoodsNum;
      }
      if (other.ItemId != 0) {
        ItemId = other.ItemId;
      }
      if (other.GoodsId != 0) {
        GoodsId = other.GoodsId;
      }
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
          case 24: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            GoodsNum = input.ReadUInt32();
            break;
          }
          case 40: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 48: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 104: {
            ShopId = input.ReadUInt32();
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
          case 24: {
            ItemId = input.ReadUInt32();
            break;
          }
          case 32: {
            GoodsNum = input.ReadUInt32();
            break;
          }
          case 40: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 48: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 104: {
            ShopId = input.ReadUInt32();
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
