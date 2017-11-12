//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Query.g by ANTLR 4.6

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
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IQueryListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public partial class QueryBaseListener : IQueryListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.selector"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSelector([NotNull] QueryParser.SelectorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.selector"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSelector([NotNull] QueryParser.SelectorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.eval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEval([NotNull] QueryParser.EvalContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.eval"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEval([NotNull] QueryParser.EvalContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.or"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOr([NotNull] QueryParser.OrContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.or"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOr([NotNull] QueryParser.OrContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.and"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAnd([NotNull] QueryParser.AndContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.and"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAnd([NotNull] QueryParser.AndContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterConstraint([NotNull] QueryParser.ConstraintContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.constraint"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitConstraint([NotNull] QueryParser.ConstraintContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGroup([NotNull] QueryParser.GroupContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.group"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGroup([NotNull] QueryParser.GroupContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.comparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparison([NotNull] QueryParser.ComparisonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.comparison"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparison([NotNull] QueryParser.ComparisonContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.comparator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparator([NotNull] QueryParser.ComparatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.comparator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparator([NotNull] QueryParser.ComparatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.comp_fiql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_fiql([NotNull] QueryParser.Comp_fiqlContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.comp_fiql"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_fiql([NotNull] QueryParser.Comp_fiqlContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.comp_alt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComp_alt([NotNull] QueryParser.Comp_altContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.comp_alt"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComp_alt([NotNull] QueryParser.Comp_altContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.reserved"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReserved([NotNull] QueryParser.ReservedContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.reserved"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReserved([NotNull] QueryParser.ReservedContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.single_quote"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSingle_quote([NotNull] QueryParser.Single_quoteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.single_quote"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSingle_quote([NotNull] QueryParser.Single_quoteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.double_quote"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDouble_quote([NotNull] QueryParser.Double_quoteContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.double_quote"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDouble_quote([NotNull] QueryParser.Double_quoteContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterArguments([NotNull] QueryParser.ArgumentsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.arguments"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitArguments([NotNull] QueryParser.ArgumentsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="QueryParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] QueryParser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="QueryParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] QueryParser.ValueContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Autumn.Mvc.Data.Models.Queries
