// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoryLineTrialAvatarChangeScNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from StoryLineTrialAvatarChangeScNotify.proto</summary>
  public static partial class StoryLineTrialAvatarChangeScNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for StoryLineTrialAvatarChangeScNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoryLineTrialAvatarChangeScNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihTdG9yeUxpbmVUcmlhbEF2YXRhckNoYW5nZVNjTm90aWZ5LnByb3RvIk4K",
            "IlN0b3J5TGluZVRyaWFsQXZhdGFyQ2hhbmdlU2NOb3RpZnkSEwoLS0hCTEtF",
            "TURBSEgYBSADKA0SEwoLSkdQSERFTEJNQ0cYCSADKA1CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.StoryLineTrialAvatarChangeScNotify), global::EggLink.DanhengServer.Proto.StoryLineTrialAvatarChangeScNotify.Parser, new[]{ "KHBLKEMDAHH", "JGPHDELBMCG" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class StoryLineTrialAvatarChangeScNotify : pb::IMessage<StoryLineTrialAvatarChangeScNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StoryLineTrialAvatarChangeScNotify> _parser = new pb::MessageParser<StoryLineTrialAvatarChangeScNotify>(() => new StoryLineTrialAvatarChangeScNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StoryLineTrialAvatarChangeScNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.StoryLineTrialAvatarChangeScNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoryLineTrialAvatarChangeScNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoryLineTrialAvatarChangeScNotify(StoryLineTrialAvatarChangeScNotify other) : this() {
      kHBLKEMDAHH_ = other.kHBLKEMDAHH_.Clone();
      jGPHDELBMCG_ = other.jGPHDELBMCG_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StoryLineTrialAvatarChangeScNotify Clone() {
      return new StoryLineTrialAvatarChangeScNotify(this);
    }

    /// <summary>Field number for the "KHBLKEMDAHH" field.</summary>
    public const int KHBLKEMDAHHFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_kHBLKEMDAHH_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> kHBLKEMDAHH_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> KHBLKEMDAHH {
      get { return kHBLKEMDAHH_; }
    }

    /// <summary>Field number for the "JGPHDELBMCG" field.</summary>
    public const int JGPHDELBMCGFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_jGPHDELBMCG_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> jGPHDELBMCG_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> JGPHDELBMCG {
      get { return jGPHDELBMCG_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StoryLineTrialAvatarChangeScNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StoryLineTrialAvatarChangeScNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!kHBLKEMDAHH_.Equals(other.kHBLKEMDAHH_)) return false;
      if(!jGPHDELBMCG_.Equals(other.jGPHDELBMCG_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= kHBLKEMDAHH_.GetHashCode();
      hash ^= jGPHDELBMCG_.GetHashCode();
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
      kHBLKEMDAHH_.WriteTo(output, _repeated_kHBLKEMDAHH_codec);
      jGPHDELBMCG_.WriteTo(output, _repeated_jGPHDELBMCG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      kHBLKEMDAHH_.WriteTo(ref output, _repeated_kHBLKEMDAHH_codec);
      jGPHDELBMCG_.WriteTo(ref output, _repeated_jGPHDELBMCG_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += kHBLKEMDAHH_.CalculateSize(_repeated_kHBLKEMDAHH_codec);
      size += jGPHDELBMCG_.CalculateSize(_repeated_jGPHDELBMCG_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StoryLineTrialAvatarChangeScNotify other) {
      if (other == null) {
        return;
      }
      kHBLKEMDAHH_.Add(other.kHBLKEMDAHH_);
      jGPHDELBMCG_.Add(other.jGPHDELBMCG_);
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
          case 42:
          case 40: {
            kHBLKEMDAHH_.AddEntriesFrom(input, _repeated_kHBLKEMDAHH_codec);
            break;
          }
          case 74:
          case 72: {
            jGPHDELBMCG_.AddEntriesFrom(input, _repeated_jGPHDELBMCG_codec);
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
          case 42:
          case 40: {
            kHBLKEMDAHH_.AddEntriesFrom(ref input, _repeated_kHBLKEMDAHH_codec);
            break;
          }
          case 74:
          case 72: {
            jGPHDELBMCG_.AddEntriesFrom(ref input, _repeated_jGPHDELBMCG_codec);
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
