namespace Felandil.AdoNetExtension
{
  using System.Data;

  /// <summary>
  /// The db command extension.
  /// </summary>
  public static class DbCommandExtension
  {
    /// <summary>
    /// The create parameter.
    /// </summary>
    /// <param name="command">
    /// The command.
    /// </param>
    /// <param name="type">
    /// The type.
    /// </param>
    /// <param name="parameterName">
    /// The parameter name.
    /// </param>
    /// <param name="parameterValue">
    /// The parameter value.
    /// </param>
    /// <returns>
    /// The <see cref="IDbDataParameter"/>.
    /// </returns>
    public static IDbDataParameter CreateParameter(this IDbCommand command, DbType type, string parameterName, object parameterValue)
    {
      var parameter = command.CreateParameter();

      parameter.DbType = type;
      parameter.ParameterName = parameterName;
      parameter.Value = parameterValue;

      return parameter;
    }
  }
}