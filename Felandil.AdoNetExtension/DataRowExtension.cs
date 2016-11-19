// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The data row extension.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.AdoNetExtension
{
  using System.Data;

  /// <summary>
  /// The data row extension.
  /// </summary>
  public static class DataRowExtension
  {
    #region Public Methods and Operators

    /// <summary>
    /// The column.
    /// </summary>
    /// <param name="row">
    /// The row.
    /// </param>
    /// <param name="columnName">
    /// The column name.
    /// </param>
    /// <typeparam name="TOut">
    /// Output type.
    /// </typeparam>
    /// <returns>
    /// The <see cref="TOut"/>.
    /// </returns>
    public static TOut Column<TOut>(this DataRow row, string columnName)
    {
      if (row[columnName] == null
          || ((typeof(TOut) != typeof(string) || typeof(TOut) != typeof(char)) && string.IsNullOrEmpty(row[columnName].ToString())))
      {
        return (TOut)default(object);
      }

      return row[columnName].ToString().ToType<TOut>();
    }

    #endregion
  }
}