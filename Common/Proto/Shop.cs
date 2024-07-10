// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Shop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from Shop.proto</summary>
  public static partial class ShopReflection {

    #region Descriptor
    /// <summary>File descriptor for Shop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpTaG9wLnByb3RvGgtHb29kcy5wcm90byKgAQoEU2hvcBIfChdjaXR5X3Rh",
            "a2VuX2xldmVsX3Jld2FyZBgEIAEoBBIQCghjaXR5X2V4cBgCIAEoDRIQCghl",
            "bmRfdGltZRgPIAEoAxISCgpjaXR5X2xldmVsGAggASgNEg8KB3Nob3BfaWQY",
            "DiABKA0SGgoKZ29vZHNfbGlzdBgJIAMoCzIGLkdvb2RzEhIKCmJlZ2luX3Rp",
            "bWUYCiABKANCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.GoodsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.Shop), global::EggLink.DanhengServer.Proto.Shop.Parser, new[]{ "CityTakenLevelReward", "CityExp", "EndTime", "CityLevel", "ShopId", "GoodsList", "BeginTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Shop : pb::IMessage<Shop>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Shop> _parser = new pb::MessageParser<Shop>(() => new Shop());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Shop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ShopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop(Shop other) : this() {
      cityTakenLevelReward_ = other.cityTakenLevelReward_;
      cityExp_ = other.cityExp_;
      endTime_ = other.endTime_;
      cityLevel_ = other.cityLevel_;
      shopId_ = other.shopId_;
      goodsList_ = other.goodsList_.Clone();
      beginTime_ = other.beginTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Shop Clone() {
      return new Shop(this);
    }

    /// <summary>Field number for the "city_taken_level_reward" field.</summary>
    public const int CityTakenLevelRewardFieldNumber = 4;
    private ulong cityTakenLevelReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CityTakenLevelReward {
      get { return cityTakenLevelReward_; }
      set {
        cityTakenLevelReward_ = value;
      }
    }

    /// <summary>Field number for the "city_exp" field.</summary>
    public const int CityExpFieldNumber = 2;
    private uint cityExp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityExp {
      get { return cityExp_; }
      set {
        cityExp_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 15;
    private long endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "city_level" field.</summary>
    public const int CityLevelFieldNumber = 8;
    private uint cityLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CityLevel {
      get { return cityLevel_; }
      set {
        cityLevel_ = value;
      }
    }

    /// <summary>Field number for the "shop_id" field.</summary>
    public const int ShopIdFieldNumber = 14;
    private uint shopId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShopId {
      get { return shopId_; }
      set {
        shopId_ = value;
      }
    }

    /// <summary>Field number for the "goods_list" field.</summary>
    public const int GoodsListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.Goods> _repeated_goodsList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.Goods.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Goods> goodsList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Goods>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.Goods> GoodsList {
      get { return goodsList_; }
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 10;
    private long beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Shop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Shop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CityTakenLevelReward != other.CityTakenLevelReward) return false;
      if (CityExp != other.CityExp) return false;
      if (EndTime != other.EndTime) return false;
      if (CityLevel != other.CityLevel) return false;
      if (ShopId != other.ShopId) return false;
      if(!goodsList_.Equals(other.goodsList_)) return false;
      if (BeginTime != other.BeginTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CityTakenLevelReward != 0UL) hash ^= CityTakenLevelReward.GetHashCode();
      if (CityExp != 0) hash ^= CityExp.GetHashCode();
      if (EndTime != 0L) hash ^= EndTime.GetHashCode();
      if (CityLevel != 0) hash ^= CityLevel.GetHashCode();
      if (ShopId != 0) hash ^= ShopId.GetHashCode();
      hash ^= goodsList_.GetHashCode();
      if (BeginTime != 0L) hash ^= BeginTime.GetHashCode();
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
      if (CityExp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CityExp);
      }
      if (CityTakenLevelReward != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(CityTakenLevelReward);
      }
      if (CityLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityLevel);
      }
      goodsList_.WriteTo(output, _repeated_goodsList_codec);
      if (BeginTime != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(BeginTime);
      }
      if (ShopId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ShopId);
      }
      if (EndTime != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(EndTime);
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
      if (CityExp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CityExp);
      }
      if (CityTakenLevelReward != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(CityTakenLevelReward);
      }
      if (CityLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CityLevel);
      }
      goodsList_.WriteTo(ref output, _repeated_goodsList_codec);
      if (BeginTime != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(BeginTime);
      }
      if (ShopId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ShopId);
      }
      if (EndTime != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(EndTime);
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
      if (CityTakenLevelReward != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CityTakenLevelReward);
      }
      if (CityExp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityExp);
      }
      if (EndTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EndTime);
      }
      if (CityLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityLevel);
      }
      if (ShopId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShopId);
      }
      size += goodsList_.CalculateSize(_repeated_goodsList_codec);
      if (BeginTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BeginTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Shop other) {
      if (other == null) {
        return;
      }
      if (other.CityTakenLevelReward != 0UL) {
        CityTakenLevelReward = other.CityTakenLevelReward;
      }
      if (other.CityExp != 0) {
        CityExp = other.CityExp;
      }
      if (other.EndTime != 0L) {
        EndTime = other.EndTime;
      }
      if (other.CityLevel != 0) {
        CityLevel = other.CityLevel;
      }
      if (other.ShopId != 0) {
        ShopId = other.ShopId;
      }
      goodsList_.Add(other.goodsList_);
      if (other.BeginTime != 0L) {
        BeginTime = other.BeginTime;
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
          case 16: {
            CityExp = input.ReadUInt32();
            break;
          }
          case 32: {
            CityTakenLevelReward = input.ReadUInt64();
            break;
          }
          case 64: {
            CityLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            goodsList_.AddEntriesFrom(input, _repeated_goodsList_codec);
            break;
          }
          case 80: {
            BeginTime = input.ReadInt64();
            break;
          }
          case 112: {
            ShopId = input.ReadUInt32();
            break;
          }
          case 120: {
            EndTime = input.ReadInt64();
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
          case 16: {
            CityExp = input.ReadUInt32();
            break;
          }
          case 32: {
            CityTakenLevelReward = input.ReadUInt64();
            break;
          }
          case 64: {
            CityLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            goodsList_.AddEntriesFrom(ref input, _repeated_goodsList_codec);
            break;
          }
          case 80: {
            BeginTime = input.ReadInt64();
            break;
          }
          case 112: {
            ShopId = input.ReadUInt32();
            break;
          }
          case 120: {
            EndTime = input.ReadInt64();
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
