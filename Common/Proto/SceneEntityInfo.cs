// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from SceneEntityInfo.proto</summary>
  public static partial class SceneEntityInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVTY2VuZUVudGl0eUluZm8ucHJvdG8aElNjZW5lTnBjSW5mby5wcm90bxoQ",
            "TW90aW9uSW5mby5wcm90bxoZU2NlbmVOcGNNb25zdGVySW5mby5wcm90bxoZ",
            "U2NlbmVTdW1tb25Vbml0SW5mby5wcm90bxoTU2NlbmVQcm9wSW5mby5wcm90",
            "bxoUU2NlbmVBY3RvckluZm8ucHJvdG8ilAIKD1NjZW5lRW50aXR5SW5mbxIQ",
            "Cghncm91cF9pZBgCIAEoDRIbCgZtb3Rpb24YByABKAsyCy5Nb3Rpb25JbmZv",
            "EhEKCWVudGl0eV9pZBgGIAEoDRIPCgdpbnN0X2lkGA8gASgNEh4KBWFjdG9y",
            "GAkgASgLMg8uU2NlbmVBY3RvckluZm8SKQoLbnBjX21vbnN0ZXIYBSABKAsy",
            "FC5TY2VuZU5wY01vbnN0ZXJJbmZvEhoKA25wYxgMIAEoCzINLlNjZW5lTnBj",
            "SW5mbxIcCgRwcm9wGAogASgLMg4uU2NlbmVQcm9wSW5mbxIpCgtzdW1tb25f",
            "dW5pdBgOIAEoCzIULlNjZW5lU3VtbW9uVW5pdEluZm9CHqoCG0VnZ0xpbmsu",
            "RGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::EggLink.DanhengServer.Proto.SceneNpcInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.MotionInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneSummonUnitInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.ScenePropInfoReflection.Descriptor, global::EggLink.DanhengServer.Proto.SceneActorInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EggLink.DanhengServer.Proto.SceneEntityInfo), global::EggLink.DanhengServer.Proto.SceneEntityInfo.Parser, new[]{ "GroupId", "Motion", "EntityId", "InstId", "Actor", "NpcMonster", "Npc", "Prop", "SummonUnit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SceneEntityInfo : pb::IMessage<SceneEntityInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityInfo> _parser = new pb::MessageParser<SceneEntityInfo>(() => new SceneEntityInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EggLink.DanhengServer.Proto.SceneEntityInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityInfo(SceneEntityInfo other) : this() {
      groupId_ = other.groupId_;
      motion_ = other.motion_ != null ? other.motion_.Clone() : null;
      entityId_ = other.entityId_;
      instId_ = other.instId_;
      actor_ = other.actor_ != null ? other.actor_.Clone() : null;
      npcMonster_ = other.npcMonster_ != null ? other.npcMonster_.Clone() : null;
      npc_ = other.npc_ != null ? other.npc_.Clone() : null;
      prop_ = other.prop_ != null ? other.prop_.Clone() : null;
      summonUnit_ = other.summonUnit_ != null ? other.summonUnit_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityInfo Clone() {
      return new SceneEntityInfo(this);
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 2;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "motion" field.</summary>
    public const int MotionFieldNumber = 7;
    private global::EggLink.DanhengServer.Proto.MotionInfo motion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.MotionInfo Motion {
      get { return motion_; }
      set {
        motion_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 6;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "inst_id" field.</summary>
    public const int InstIdFieldNumber = 15;
    private uint instId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstId {
      get { return instId_; }
      set {
        instId_ = value;
      }
    }

    /// <summary>Field number for the "actor" field.</summary>
    public const int ActorFieldNumber = 9;
    private global::EggLink.DanhengServer.Proto.SceneActorInfo actor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneActorInfo Actor {
      get { return actor_; }
      set {
        actor_ = value;
      }
    }

    /// <summary>Field number for the "npc_monster" field.</summary>
    public const int NpcMonsterFieldNumber = 5;
    private global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo npcMonster_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo NpcMonster {
      get { return npcMonster_; }
      set {
        npcMonster_ = value;
      }
    }

    /// <summary>Field number for the "npc" field.</summary>
    public const int NpcFieldNumber = 12;
    private global::EggLink.DanhengServer.Proto.SceneNpcInfo npc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneNpcInfo Npc {
      get { return npc_; }
      set {
        npc_ = value;
      }
    }

    /// <summary>Field number for the "prop" field.</summary>
    public const int PropFieldNumber = 10;
    private global::EggLink.DanhengServer.Proto.ScenePropInfo prop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.ScenePropInfo Prop {
      get { return prop_; }
      set {
        prop_ = value;
      }
    }

    /// <summary>Field number for the "summon_unit" field.</summary>
    public const int SummonUnitFieldNumber = 14;
    private global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo summonUnit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo SummonUnit {
      get { return summonUnit_; }
      set {
        summonUnit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(Motion, other.Motion)) return false;
      if (EntityId != other.EntityId) return false;
      if (InstId != other.InstId) return false;
      if (!object.Equals(Actor, other.Actor)) return false;
      if (!object.Equals(NpcMonster, other.NpcMonster)) return false;
      if (!object.Equals(Npc, other.Npc)) return false;
      if (!object.Equals(Prop, other.Prop)) return false;
      if (!object.Equals(SummonUnit, other.SummonUnit)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (motion_ != null) hash ^= Motion.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (InstId != 0) hash ^= InstId.GetHashCode();
      if (actor_ != null) hash ^= Actor.GetHashCode();
      if (npcMonster_ != null) hash ^= NpcMonster.GetHashCode();
      if (npc_ != null) hash ^= Npc.GetHashCode();
      if (prop_ != null) hash ^= Prop.GetHashCode();
      if (summonUnit_ != null) hash ^= SummonUnit.GetHashCode();
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (npcMonster_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(NpcMonster);
      }
      if (EntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EntityId);
      }
      if (motion_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Motion);
      }
      if (actor_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Actor);
      }
      if (prop_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Prop);
      }
      if (npc_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Npc);
      }
      if (summonUnit_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(SummonUnit);
      }
      if (InstId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(InstId);
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
      if (GroupId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(GroupId);
      }
      if (npcMonster_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(NpcMonster);
      }
      if (EntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EntityId);
      }
      if (motion_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Motion);
      }
      if (actor_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Actor);
      }
      if (prop_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Prop);
      }
      if (npc_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Npc);
      }
      if (summonUnit_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(SummonUnit);
      }
      if (InstId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(InstId);
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
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (motion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Motion);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (InstId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstId);
      }
      if (actor_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Actor);
      }
      if (npcMonster_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NpcMonster);
      }
      if (npc_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Npc);
      }
      if (prop_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Prop);
      }
      if (summonUnit_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SummonUnit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityInfo other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.motion_ != null) {
        if (motion_ == null) {
          Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
        }
        Motion.MergeFrom(other.Motion);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.InstId != 0) {
        InstId = other.InstId;
      }
      if (other.actor_ != null) {
        if (actor_ == null) {
          Actor = new global::EggLink.DanhengServer.Proto.SceneActorInfo();
        }
        Actor.MergeFrom(other.Actor);
      }
      if (other.npcMonster_ != null) {
        if (npcMonster_ == null) {
          NpcMonster = new global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo();
        }
        NpcMonster.MergeFrom(other.NpcMonster);
      }
      if (other.npc_ != null) {
        if (npc_ == null) {
          Npc = new global::EggLink.DanhengServer.Proto.SceneNpcInfo();
        }
        Npc.MergeFrom(other.Npc);
      }
      if (other.prop_ != null) {
        if (prop_ == null) {
          Prop = new global::EggLink.DanhengServer.Proto.ScenePropInfo();
        }
        Prop.MergeFrom(other.Prop);
      }
      if (other.summonUnit_ != null) {
        if (summonUnit_ == null) {
          SummonUnit = new global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo();
        }
        SummonUnit.MergeFrom(other.SummonUnit);
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (npcMonster_ == null) {
              NpcMonster = new global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo();
            }
            input.ReadMessage(NpcMonster);
            break;
          }
          case 48: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 74: {
            if (actor_ == null) {
              Actor = new global::EggLink.DanhengServer.Proto.SceneActorInfo();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 82: {
            if (prop_ == null) {
              Prop = new global::EggLink.DanhengServer.Proto.ScenePropInfo();
            }
            input.ReadMessage(Prop);
            break;
          }
          case 98: {
            if (npc_ == null) {
              Npc = new global::EggLink.DanhengServer.Proto.SceneNpcInfo();
            }
            input.ReadMessage(Npc);
            break;
          }
          case 114: {
            if (summonUnit_ == null) {
              SummonUnit = new global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo();
            }
            input.ReadMessage(SummonUnit);
            break;
          }
          case 120: {
            InstId = input.ReadUInt32();
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
            GroupId = input.ReadUInt32();
            break;
          }
          case 42: {
            if (npcMonster_ == null) {
              NpcMonster = new global::EggLink.DanhengServer.Proto.SceneNpcMonsterInfo();
            }
            input.ReadMessage(NpcMonster);
            break;
          }
          case 48: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 58: {
            if (motion_ == null) {
              Motion = new global::EggLink.DanhengServer.Proto.MotionInfo();
            }
            input.ReadMessage(Motion);
            break;
          }
          case 74: {
            if (actor_ == null) {
              Actor = new global::EggLink.DanhengServer.Proto.SceneActorInfo();
            }
            input.ReadMessage(Actor);
            break;
          }
          case 82: {
            if (prop_ == null) {
              Prop = new global::EggLink.DanhengServer.Proto.ScenePropInfo();
            }
            input.ReadMessage(Prop);
            break;
          }
          case 98: {
            if (npc_ == null) {
              Npc = new global::EggLink.DanhengServer.Proto.SceneNpcInfo();
            }
            input.ReadMessage(Npc);
            break;
          }
          case 114: {
            if (summonUnit_ == null) {
              SummonUnit = new global::EggLink.DanhengServer.Proto.SceneSummonUnitInfo();
            }
            input.ReadMessage(SummonUnit);
            break;
          }
          case 120: {
            InstId = input.ReadUInt32();
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
