// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace NamespaceA
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct TableInFirstNS : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_23_1_20(); }
  public static TableInFirstNS GetRootAsTableInFirstNS(ByteBuffer _bb) { return GetRootAsTableInFirstNS(_bb, new TableInFirstNS()); }
  public static TableInFirstNS GetRootAsTableInFirstNS(ByteBuffer _bb, TableInFirstNS obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public TableInFirstNS __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public NamespaceA.NamespaceB.TableInNestedNS? FooTable { get { int o = __p.__offset(4); return o != 0 ? (NamespaceA.NamespaceB.TableInNestedNS?)(new NamespaceA.NamespaceB.TableInNestedNS()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }
  public NamespaceA.NamespaceB.EnumInNestedNS FooEnum { get { int o = __p.__offset(6); return o != 0 ? (NamespaceA.NamespaceB.EnumInNestedNS)__p.bb.GetSbyte(o + __p.bb_pos) : NamespaceA.NamespaceB.EnumInNestedNS.A; } }
  public bool MutateFooEnum(NamespaceA.NamespaceB.EnumInNestedNS foo_enum) { int o = __p.__offset(6); if (o != 0) { __p.bb.PutSbyte(o + __p.bb_pos, (sbyte)foo_enum); return true; } else { return false; } }
  public NamespaceA.NamespaceB.UnionInNestedNS FooUnionType { get { int o = __p.__offset(8); return o != 0 ? (NamespaceA.NamespaceB.UnionInNestedNS)__p.bb.Get(o + __p.bb_pos) : NamespaceA.NamespaceB.UnionInNestedNS.NONE; } }
  public TTable? FooUnion<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(10); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public NamespaceA.NamespaceB.TableInNestedNS FooUnionAsTableInNestedNS() { return FooUnion<NamespaceA.NamespaceB.TableInNestedNS>().Value; }
  public NamespaceA.NamespaceB.StructInNestedNS? FooStruct { get { int o = __p.__offset(12); return o != 0 ? (NamespaceA.NamespaceB.StructInNestedNS?)(new NamespaceA.NamespaceB.StructInNestedNS()).__assign(o + __p.bb_pos, __p.bb) : null; } }

  public static Offset<NamespaceA.TableInFirstNS> CreateTableInFirstNS(FlatBufferBuilder builder,
      Offset<NamespaceA.NamespaceB.TableInNestedNS> foo_tableOffset = default(Offset<NamespaceA.NamespaceB.TableInNestedNS>),
      NamespaceA.NamespaceB.EnumInNestedNS foo_enum = NamespaceA.NamespaceB.EnumInNestedNS.A,
      NamespaceA.NamespaceB.UnionInNestedNS foo_union_type = NamespaceA.NamespaceB.UnionInNestedNS.NONE,
      int foo_unionOffset = 0,
      NamespaceA.NamespaceB.StructInNestedNST foo_struct = null) {
    builder.StartTable(5);
    TableInFirstNS.AddFooStruct(builder, NamespaceA.NamespaceB.StructInNestedNS.Pack(builder, foo_struct));
    TableInFirstNS.AddFooUnion(builder, foo_unionOffset);
    TableInFirstNS.AddFooTable(builder, foo_tableOffset);
    TableInFirstNS.AddFooUnionType(builder, foo_union_type);
    TableInFirstNS.AddFooEnum(builder, foo_enum);
    return TableInFirstNS.EndTableInFirstNS(builder);
  }

  public static void StartTableInFirstNS(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddFooTable(FlatBufferBuilder builder, Offset<NamespaceA.NamespaceB.TableInNestedNS> fooTableOffset) { builder.AddOffset(0, fooTableOffset.Value, 0); }
  public static void AddFooEnum(FlatBufferBuilder builder, NamespaceA.NamespaceB.EnumInNestedNS fooEnum) { builder.AddSbyte(1, (sbyte)fooEnum, 0); }
  public static void AddFooUnionType(FlatBufferBuilder builder, NamespaceA.NamespaceB.UnionInNestedNS fooUnionType) { builder.AddByte(2, (byte)fooUnionType, 0); }
  public static void AddFooUnion(FlatBufferBuilder builder, int fooUnionOffset) { builder.AddOffset(3, fooUnionOffset, 0); }
  public static void AddFooStruct(FlatBufferBuilder builder, Offset<NamespaceA.NamespaceB.StructInNestedNS> fooStructOffset) { builder.AddStruct(4, fooStructOffset.Value, 0); }
  public static Offset<NamespaceA.TableInFirstNS> EndTableInFirstNS(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<NamespaceA.TableInFirstNS>(o);
  }
  public TableInFirstNST UnPack() {
    var _o = new TableInFirstNST();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(TableInFirstNST _o) {
    _o.FooTable = this.FooTable.HasValue ? this.FooTable.Value.UnPack() : null;
    _o.FooEnum = this.FooEnum;
    _o.FooUnion = new NamespaceA.NamespaceB.UnionInNestedNSUnion();
    _o.FooUnion.Type = this.FooUnionType;
    switch (this.FooUnionType) {
      default: break;
      case NamespaceA.NamespaceB.UnionInNestedNS.TableInNestedNS:
        _o.FooUnion.Value = this.FooUnion<NamespaceA.NamespaceB.TableInNestedNS>().HasValue ? this.FooUnion<NamespaceA.NamespaceB.TableInNestedNS>().Value.UnPack() : null;
        break;
    }
    _o.FooStruct = this.FooStruct.HasValue ? this.FooStruct.Value.UnPack() : null;
  }
  public static Offset<NamespaceA.TableInFirstNS> Pack(FlatBufferBuilder builder, TableInFirstNST _o) {
    if (_o == null) return default(Offset<NamespaceA.TableInFirstNS>);
    var _foo_table = _o.FooTable == null ? default(Offset<NamespaceA.NamespaceB.TableInNestedNS>) : NamespaceA.NamespaceB.TableInNestedNS.Pack(builder, _o.FooTable);
    var _foo_union_type = _o.FooUnion == null ? NamespaceA.NamespaceB.UnionInNestedNS.NONE : _o.FooUnion.Type;
    var _foo_union = _o.FooUnion == null ? 0 : NamespaceA.NamespaceB.UnionInNestedNSUnion.Pack(builder, _o.FooUnion);
    return CreateTableInFirstNS(
      builder,
      _foo_table,
      _o.FooEnum,
      _foo_union_type,
      _foo_union,
      _o.FooStruct);
  }
}

public class TableInFirstNST
{
  [Newtonsoft.Json.JsonProperty("foo_table")]
  public NamespaceA.NamespaceB.TableInNestedNST FooTable { get; set; }
  [Newtonsoft.Json.JsonProperty("foo_enum")]
  public NamespaceA.NamespaceB.EnumInNestedNS FooEnum { get; set; }
  [Newtonsoft.Json.JsonProperty("foo_union_type")]
  private NamespaceA.NamespaceB.UnionInNestedNS FooUnionType {
    get {
      return this.FooUnion != null ? this.FooUnion.Type : NamespaceA.NamespaceB.UnionInNestedNS.NONE;
    }
    set {
      this.FooUnion = new NamespaceA.NamespaceB.UnionInNestedNSUnion();
      this.FooUnion.Type = value;
    }
  }
  [Newtonsoft.Json.JsonProperty("foo_union")]
  [Newtonsoft.Json.JsonConverter(typeof(NamespaceA.NamespaceB.UnionInNestedNSUnion_JsonConverter))]
  public NamespaceA.NamespaceB.UnionInNestedNSUnion FooUnion { get; set; }
  [Newtonsoft.Json.JsonProperty("foo_struct")]
  public NamespaceA.NamespaceB.StructInNestedNST FooStruct { get; set; }

  public TableInFirstNST() {
    this.FooTable = null;
    this.FooEnum = NamespaceA.NamespaceB.EnumInNestedNS.A;
    this.FooUnion = null;
    this.FooStruct = new NamespaceA.NamespaceB.StructInNestedNST();
  }
}


}
