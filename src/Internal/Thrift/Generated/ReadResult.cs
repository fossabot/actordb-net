/**
 * Autogenerated by Thrift Compiler (@PACKAGE_VERSION@)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;



public partial class ReadResult : TBase
{

  public bool HasMore { get; set; }

  public List<string> Columns { get; set; }

  public List<Dictionary<string, Val>> Rows { get; set; }

  public ReadResult()
  {
  }

  public ReadResult(bool hasMore, List<string> columns, List<Dictionary<string, Val>> rows) : this()
  {
    this.HasMore = hasMore;
    this.Columns = columns;
    this.Rows = rows;
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_hasMore = false;
      bool isset_columns = false;
      bool isset_rows = false;
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Bool)
            {
              HasMore = await iprot.ReadBoolAsync(cancellationToken);
              isset_hasMore = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.List)
            {
              {
                Columns = new List<string>();
                TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  string _elem2;
                  _elem2 = await iprot.ReadStringAsync(cancellationToken);
                  Columns.Add(_elem2);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_columns = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.List)
            {
              {
                Rows = new List<Dictionary<string, Val>>();
                TList _list3 = await iprot.ReadListBeginAsync(cancellationToken);
                for(int _i4 = 0; _i4 < _list3.Count; ++_i4)
                {
                  Dictionary<string, Val> _elem5;
                  {
                    _elem5 = new Dictionary<string, Val>();
                    TMap _map6 = await iprot.ReadMapBeginAsync(cancellationToken);
                    for(int _i7 = 0; _i7 < _map6.Count; ++_i7)
                    {
                      string _key8;
                      Val _val9;
                      _key8 = await iprot.ReadStringAsync(cancellationToken);
                      _val9 = new Val();
                      await _val9.ReadAsync(iprot, cancellationToken);
                      _elem5[_key8] = _val9;
                    }
                    await iprot.ReadMapEndAsync(cancellationToken);
                  }
                  Rows.Add(_elem5);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
              isset_rows = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
      if (!isset_hasMore)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_columns)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
      if (!isset_rows)
      {
        throw new TProtocolException(TProtocolException.INVALID_DATA);
      }
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var struc = new TStruct("ReadResult");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      field.Name = "hasMore";
      field.Type = TType.Bool;
      field.ID = 1;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await oprot.WriteBoolAsync(HasMore, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      field.Name = "columns";
      field.Type = TType.List;
      field.ID = 2;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      {
        await oprot.WriteListBeginAsync(new TList(TType.String, Columns.Count), cancellationToken);
        foreach (string _iter10 in Columns)
        {
          await oprot.WriteStringAsync(_iter10, cancellationToken);
        }
        await oprot.WriteListEndAsync(cancellationToken);
      }
      await oprot.WriteFieldEndAsync(cancellationToken);
      field.Name = "rows";
      field.Type = TType.List;
      field.ID = 3;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      {
        await oprot.WriteListBeginAsync(new TList(TType.Map, Rows.Count), cancellationToken);
        foreach (Dictionary<string, Val> _iter11 in Rows)
        {
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Struct, _iter11.Count), cancellationToken);
            foreach (string _iter12 in _iter11.Keys)
            {
              await oprot.WriteStringAsync(_iter12, cancellationToken);
              await _iter11[_iter12].WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
        }
        await oprot.WriteListEndAsync(cancellationToken);
      }
      await oprot.WriteFieldEndAsync(cancellationToken);
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString()
  {
    var sb = new StringBuilder("ReadResult(");
    sb.Append(", HasMore: ");
    sb.Append(HasMore);
    sb.Append(", Columns: ");
    sb.Append(Columns);
    sb.Append(", Rows: ");
    sb.Append(Rows);
    sb.Append(")");
    return sb.ToString();
  }
}
