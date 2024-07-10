// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueActionSource.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EggLink.DanhengServer.Proto {

  /// <summary>Holder for reflection information generated from RogueActionSource.proto</summary>
  public static partial class RogueActionSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueActionSource.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueActionSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSb2d1ZUFjdGlvblNvdXJjZS5wcm90byrpBQoRUm9ndWVBY3Rpb25Tb3Vy",
            "Y2USLworUk9HVUVfQ09NTU9OX0FDVElPTl9SRVNVTFRfU09VUkNFX1RZUEVf",
            "Tk9ORRAAEjEKLVJPR1VFX0NPTU1PTl9BQ1RJT05fUkVTVUxUX1NPVVJDRV9U",
            "WVBFX1NFTEVDVBABEjIKLlJPR1VFX0NPTU1PTl9BQ1RJT05fUkVTVUxUX1NP",
            "VVJDRV9UWVBFX0VOSEFOQ0UQAhIyCi5ST0dVRV9DT01NT05fQUNUSU9OX1JF",
            "U1VMVF9TT1VSQ0VfVFlQRV9NSVJBQ0xFEAMSMwovUk9HVUVfQ09NTU9OX0FD",
            "VElPTl9SRVNVTFRfU09VUkNFX1RZUEVfRElBTE9HVUUQBBIwCixST0dVRV9D",
            "T01NT05fQUNUSU9OX1JFU1VMVF9TT1VSQ0VfVFlQRV9CT05VUxAFEi8KK1JP",
            "R1VFX0NPTU1PTl9BQ1RJT05fUkVTVUxUX1NPVVJDRV9UWVBFX1NIT1AQBhIv",
            "CitST0dVRV9DT01NT05fQUNUSU9OX1JFU1VMVF9TT1VSQ0VfVFlQRV9ESUNF",
            "EAcSLworUk9HVUVfQ09NTU9OX0FDVElPTl9SRVNVTFRfU09VUkNFX1RZUEVf",
            "QUVPThAIEjYKMlJPR1VFX0NPTU1PTl9BQ1RJT05fUkVTVUxUX1NPVVJDRV9U",
            "WVBFX0JPQVJEX0VWRU5UEAkSNQoxUk9HVUVfQ09NTU9OX0FDVElPTl9SRVNV",
            "TFRfU09VUkNFX1RZUEVfTUFaRV9TS0lMTBAKEjoKNlJPR1VFX0NPTU1PTl9B",
            "Q1RJT05fUkVTVUxUX1NPVVJDRV9UWVBFX0xFVkVMX01FQ0hBTklTTRALEi8K",
            "K1JPR1VFX0NPTU1PTl9BQ1RJT05fUkVTVUxUX1NPVVJDRV9UWVBFX0JVRkYQ",
            "DBIyCi5ST0dVRV9DT01NT05fQUNUSU9OX1JFU1VMVF9TT1VSQ0VfVFlQRV9S",
            "RUZPUkdFEA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::EggLink.DanhengServer.Proto.RogueActionSource), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueActionSource {
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_NONE")] RogueCommonActionResultSourceTypeNone = 0,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_SELECT")] RogueCommonActionResultSourceTypeSelect = 1,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_ENHANCE")] RogueCommonActionResultSourceTypeEnhance = 2,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_MIRACLE")] RogueCommonActionResultSourceTypeMiracle = 3,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_DIALOGUE")] RogueCommonActionResultSourceTypeDialogue = 4,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_BONUS")] RogueCommonActionResultSourceTypeBonus = 5,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_SHOP")] RogueCommonActionResultSourceTypeShop = 6,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_DICE")] RogueCommonActionResultSourceTypeDice = 7,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_AEON")] RogueCommonActionResultSourceTypeAeon = 8,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_BOARD_EVENT")] RogueCommonActionResultSourceTypeBoardEvent = 9,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_MAZE_SKILL")] RogueCommonActionResultSourceTypeMazeSkill = 10,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_LEVEL_MECHANISM")] RogueCommonActionResultSourceTypeLevelMechanism = 11,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_BUFF")] RogueCommonActionResultSourceTypeBuff = 12,
    [pbr::OriginalName("ROGUE_COMMON_ACTION_RESULT_SOURCE_TYPE_REFORGE")] RogueCommonActionResultSourceTypeReforge = 13,
  }

  #endregion

}

#endregion Designer generated code
