//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from AutumnQuery.g by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Autumn.Mvc.Data.Models.Queries {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="AutumnQueryParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface IAutumnQueryListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSelector([NotNull] AutumnQueryParser.SelectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.selector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSelector([NotNull] AutumnQueryParser.SelectorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.eval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEval([NotNull] AutumnQueryParser.EvalContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.eval"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEval([NotNull] AutumnQueryParser.EvalContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.or"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOr([NotNull] AutumnQueryParser.OrContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.or"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOr([NotNull] AutumnQueryParser.OrContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAnd([NotNull] AutumnQueryParser.AndContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.and"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAnd([NotNull] AutumnQueryParser.AndContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstraint([NotNull] AutumnQueryParser.ConstraintContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.constraint"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstraint([NotNull] AutumnQueryParser.ConstraintContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGroup([NotNull] AutumnQueryParser.GroupContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.group"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGroup([NotNull] AutumnQueryParser.GroupContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparison([NotNull] AutumnQueryParser.ComparisonContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.comparison"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparison([NotNull] AutumnQueryParser.ComparisonContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.comparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComparator([NotNull] AutumnQueryParser.ComparatorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.comparator"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComparator([NotNull] AutumnQueryParser.ComparatorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.comp_fiql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp_fiql([NotNull] AutumnQueryParser.Comp_fiqlContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.comp_fiql"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp_fiql([NotNull] AutumnQueryParser.Comp_fiqlContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.comp_alt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp_alt([NotNull] AutumnQueryParser.Comp_altContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.comp_alt"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp_alt([NotNull] AutumnQueryParser.Comp_altContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.reserved"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReserved([NotNull] AutumnQueryParser.ReservedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.reserved"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReserved([NotNull] AutumnQueryParser.ReservedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.single_quote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSingle_quote([NotNull] AutumnQueryParser.Single_quoteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.single_quote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSingle_quote([NotNull] AutumnQueryParser.Single_quoteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.double_quote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDouble_quote([NotNull] AutumnQueryParser.Double_quoteContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.double_quote"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDouble_quote([NotNull] AutumnQueryParser.Double_quoteContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArguments([NotNull] AutumnQueryParser.ArgumentsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.arguments"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArguments([NotNull] AutumnQueryParser.ArgumentsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="AutumnQueryParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterValue([NotNull] AutumnQueryParser.ValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="AutumnQueryParser.value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitValue([NotNull] AutumnQueryParser.ValueContext context);
}
} // namespace Autumn.Mvc.Data.Models.Queries