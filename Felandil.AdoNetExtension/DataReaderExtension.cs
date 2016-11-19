// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The data reader extension.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Felandil.AdoNetExtension
{
  using System.Data;

  /// <summary>
  /// The data reader extension.
  /// </summary>
  public static class DataReaderExtension
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
    /// The type.
    /// </typeparam>
    /// <returns>
    /// The <see cref="TOut"/>.
    /// </returns>
    public static TOut Column<TOut>(this IDataReader row, string columnName)
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