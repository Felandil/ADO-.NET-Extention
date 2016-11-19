// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdoNetExample.cs" company="Felandil IT">
//   Copyright (c) 2014 - 2016 Felandil IT. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.AdoNetExtension.Example
{
  using System.Data;
  using System.Data.SqlClient;

  /// <summary>
  /// The ado net example.
  /// </summary>
  public class AdoNetExample
  {
    #region Public Methods and Operators

    /// <summary>
    /// The get some value via data reader.
    /// </summary>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public int GetSomeValueViaDataReader()
    {
      using (var connection = new SqlConnection("someconnectionstring"))
      {
        connection.Open();

        using (var command = new SqlCommand("SomeSqlQuery", connection))
        {
          var reader = command.ExecuteReader();

          return reader.Read() ? reader.Column<int>("SomeColumnName") : 0;
        }
      }
    }

    /// <summary>
    /// The get some value via data row.
    /// </summary>
    /// <returns>
    /// The <see cref="int"/>.
    /// </returns>
    public int GetSomeValueViaDataRow()
    {
      var result = new DataTable();

      using (var connection = new SqlConnection("someconnectionstring"))
      {
        connection.Open();

        using (var dataAdapter = new SqlDataAdapter("SomeSqlQuery", connection))
        {
          dataAdapter.Fill(result);
        }
      }

      return result.Rows.Count > 0 ? result.Rows[0].Column<int>("SomeColumnName") : 0;
    }

    #endregion
  }
}