// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ContentPackageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from ContentPackageData.proto</summary>
  public static partial class ContentPackageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for ContentPackageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContentPackageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDb250ZW50UGFja2FnZURhdGEucHJvdG8aEUNvbnRlbnRJbmZvLnByb3Rv",
            "IlIKEkNvbnRlbnRQYWNrYWdlRGF0YRInChFjb250ZW50X2luZm9fbGlzdBgJ",
            "IAMoCzIMLkNvbnRlbnRJbmZvEhMKC0FHSkJNSEJNRklNGAogASgNQh6qAhtF",
            "Z2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.ContentInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.ContentPackageData), global::EggLink.DanhengServer.Proto.ContentPackageData.Parser, new[]{ "ContentInfoList", "AGJBMHBMFIM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ContentPackageData : pb::IMessage<ContentPackageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ContentPackageData> _parser = new pb::MessageParser<ContentPackageData>(() => new ContentPackageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ContentPackageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.ContentPackageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentPackageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentPackageData(ContentPackageData other) : this() {
      contentInfoList_ = other.contentInfoList_.Clone();
      aGJBMHBMFIM_ = other.aGJBMHBMFIM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentPackageData Clone() {
      return new ContentPackageData(this);
    }

    /// <summary>Field number for the "content_info_list" field.</summary>
    public const int ContentInfoListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::EggLink.DanhengServer.Proto.ContentInfo> _repeated_contentInfoList_codec
        = pb::FieldCodec.ForMessage(74, global::EggLink.DanhengServer.Proto.ContentInfo.Parser);
    private readonly pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ContentInfo> contentInfoList_ = new pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ContentInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::EggLink.DanhengServer.Proto.ContentInfo> ContentInfoList {
      get { return contentInfoList_; }
    }

    /// <summary>Field number for the "AGJBMHBMFIM" field.</summary>
    public const int AGJBMHBMFIMFieldNumber = 10;
    private uint aGJBMHBMFIM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AGJBMHBMFIM {
      get { return aGJBMHBMFIM_; }
      set {
        aGJBMHBMFIM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ContentPackageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ContentPackageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!contentInfoList_.Equals(other.contentInfoList_)) return false;
      if (AGJBMHBMFIM != other.AGJBMHBMFIM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= contentInfoList_.GetHashCode();
      if (AGJBMHBMFIM != 0) hash ^= AGJBMHBMFIM.GetHashCode();
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
      contentInfoList_.WriteTo(output, _repeated_contentInfoList_codec);
      if (AGJBMHBMFIM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AGJBMHBMFIM);
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
      contentInfoList_.WriteTo(ref output, _repeated_contentInfoList_codec);
      if (AGJBMHBMFIM != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AGJBMHBMFIM);
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
      size += contentInfoList_.CalculateSize(_repeated_contentInfoList_codec);
      if (AGJBMHBMFIM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AGJBMHBMFIM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ContentPackageData other) {
      if (other == null) {
        return;
      }
      contentInfoList_.Add(other.contentInfoList_);
      if (other.AGJBMHBMFIM != 0) {
        AGJBMHBMFIM = other.AGJBMHBMFIM;
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
          case 74: {
            contentInfoList_.AddEntriesFrom(input, _repeated_contentInfoList_codec);
            break;
          }
          case 80: {
            AGJBMHBMFIM = input.ReadUInt32();
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
          case 74: {
            contentInfoList_.AddEntriesFrom(ref input, _repeated_contentInfoList_codec);
            break;
          }
          case 80: {
            AGJBMHBMFIM = input.ReadUInt32();
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
