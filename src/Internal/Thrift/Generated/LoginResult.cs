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



public partial class LoginResult : TBase
{
  private string _error;
  private List<string> _readaccess;
  private List<string> _writeaccess;

  public bool Success { get; set; }

  public string Error
  {
    get
    {
      return _error;
    }
    set
    {
      __isset.error = true;
      this._error = value;
    }
  }

  public List<string> Readaccess
  {
    get
    {
      return _readaccess;
    }
    set
    {
      __isset.readaccess = true;
      this._readaccess = value;
    }
  }

  public List<string> Writeaccess
  {
    get
    {
      return _writeaccess;
    }
    set
    {
      __isset.writeaccess = true;
      this._writeaccess = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool error;
    public bool readaccess;
    public bool writeaccess;
  }

  public LoginResult()
  {
  }

  public LoginResult(bool success) : this()
  {
    this.Success = success;
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      bool isset_success = false;
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
              Success = await iprot.ReadBoolAsync(cancellationToken);
              isset_success = true;
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.String)
            {
              Error = await iprot.ReadStringAsync(cancellationToken);
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
                Readaccess = new List<string>();
                TList _list13 = await iprot.ReadListBeginAsync(cancellationToken);
                for(int _i14 = 0; _i14 < _list13.Count; ++_i14)
                {
                  string _elem15;
                  _elem15 = await iprot.ReadStringAsync(cancellationToken);
                  Readaccess.Add(_elem15);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.List)
            {
              {
                Writeaccess = new List<string>();
                TList _list16 = await iprot.ReadListBeginAsync(cancellationToken);
                for(int _i17 = 0; _i17 < _list16.Count; ++_i17)
                {
                  string _elem18;
                  _elem18 = await iprot.ReadStringAsync(cancellationToken);
                  Writeaccess.Add(_elem18);
                }
                await iprot.ReadListEndAsync(cancellationToken);
              }
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
      if (!isset_success)
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
      var struc = new TStruct("LoginResult");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      field.Name = "success";
      field.Type = TType.Bool;
      field.ID = 1;
      await oprot.WriteFieldBeginAsync(field, cancellationToken);
      await oprot.WriteBoolAsync(Success, cancellationToken);
      await oprot.WriteFieldEndAsync(cancellationToken);
      if (Error != null && __isset.error)
      {
        field.Name = "error";
        field.Type = TType.String;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Error, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Readaccess != null && __isset.readaccess)
      {
        field.Name = "readaccess";
        field.Type = TType.List;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Readaccess.Count), cancellationToken);
          foreach (string _iter19 in Readaccess)
          {
            await oprot.WriteStringAsync(_iter19, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Writeaccess != null && __isset.writeaccess)
      {
        field.Name = "writeaccess";
        field.Type = TType.List;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Writeaccess.Count), cancellationToken);
          foreach (string _iter20 in Writeaccess)
          {
            await oprot.WriteStringAsync(_iter20, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
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
    var sb = new StringBuilder("LoginResult(");
    sb.Append(", Success: ");
    sb.Append(Success);
    if (Error != null && __isset.error)
    {
      sb.Append(", Error: ");
      sb.Append(Error);
    }
    if (Readaccess != null && __isset.readaccess)
    {
      sb.Append(", Readaccess: ");
      sb.Append(Readaccess);
    }
    if (Writeaccess != null && __isset.writeaccess)
    {
      sb.Append(", Writeaccess: ");
      sb.Append(Writeaccess);
    }
    sb.Append(")");
    return sb.ToString();
  }
}
