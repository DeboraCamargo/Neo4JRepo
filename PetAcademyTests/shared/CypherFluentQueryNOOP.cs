using Neo4jClient.Cypher;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PetAcademyTests.Shared
{
    public class CypherFluentQueryNOOP<TResult> : ICypherFluentQuery<TResult>, IOrderedCypherFluentQuery
    {
        public CypherQuery Query => throw new NotImplementedException();

        public virtual ICypherFluentQueryAdvanced Advanced => throw new NotImplementedException();

        public virtual ICypherFluentQuery WithQueryStats => throw new NotImplementedException();

        public virtual ICypherFluentQuery Read => throw new NotImplementedException();

        public virtual ICypherFluentQuery Write => throw new NotImplementedException();


        public virtual Task<IEnumerable<TResult>> ResultsAsyncMock()
        {
            return null;
        }

        public virtual Task<IEnumerable<TResult>> ResultsAsync => ResultsAsyncMock();

        public virtual ICypherFluentQuery AndWhere(string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1>(Expression<Func<T1, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2>(Expression<Func<T1, T2, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3>(Expression<Func<T1, T2, T3, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4>(Expression<Func<T1, T2, T3, T4, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5>(Expression<Func<T1, T2, T3, T4, T5, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6>(Expression<Func<T1, T2, T3, T4, T5, T6, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf(bool condition, string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1>(bool condition, Expression<Func<T1, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2>(bool condition, Expression<Func<T1, T2, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3>(bool condition, Expression<Func<T1, T2, T3, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4>(bool condition, Expression<Func<T1, T2, T3, T4, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5>(bool condition, Expression<Func<T1, T2, T3, T4, T5, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery AndWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Call(string storedProcedureText)
        {
            return this;
        }

        public virtual ICypherFluentQuery Create(string createText)
        {
            return this;
        }

        public virtual ICypherFluentQuery CreateDatabase(string databaseName, bool ifNotExists = false)
        {
            return this;
        }

        public virtual ICypherFluentQuery CreateOrReplaceDatabase(string databaseName)
        {
            return this;
        }

        public virtual ICypherFluentQuery CreateUnique(string createUniqueText)
        {
            return this;
        }

        public virtual ICypherFluentQuery CreateUniqueConstraint(string identity, string property)
        {
            return this;
        }

        public virtual ICypherFluentQuery CustomHeaders(NameValueCollection headers)
        {
            return this;
        }

        public virtual ICypherFluentQuery Delete(string identities)
        {
            return this;
        }

        public virtual ICypherFluentQuery DetachDelete(string identities)
        {
            return this;
        }

        public virtual ICypherFluentQuery Drop(string dropText)
        {
            return this;
        }

        public virtual ICypherFluentQuery DropDatabase(string databaseName, bool dumpData = false)
        {
            return this;
        }

        public virtual ICypherFluentQuery DropDatabaseIfExists(string databaseName, bool dumpData = false)
        {
            return this;
        }

        public virtual ICypherFluentQuery DropUniqueConstraint(string identity, string property)
        {
            return this;
        }

        public virtual Task ExecuteWithoutResultsAsync()
        {
            throw new NotImplementedException();
        }

        public virtual ICypherFluentQuery ForEach(string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery Limit(int? limit)
        {
            return this;
        }

        public virtual ICypherFluentQuery LoadCsv(Uri fileUri, string identifier, bool withHeaders = false, string fieldTerminator = null, int? periodicCommit = null)
        {
            return this;
        }

        public virtual ICypherFluentQuery Match(params string[] matchText)
        {
            return this;
        }

        public virtual ICypherFluentQuery MaxExecutionTime(int milliseconds)
        {
            return this;
        }

        public virtual ICypherFluentQuery Merge(string mergeText)
        {
            return this;
        }

        public virtual ICypherFluentQuery OnCreate()
        {
            return this;
        }

        public virtual ICypherFluentQuery OnMatch()
        {
            return this;
        }

        public virtual ICypherFluentQuery OptionalMatch(string pattern)
        {
            return this;
        }

        public IOrderedCypherFluentQuery OrderBy(params string[] properties)
        {
            return this;
        }

        public IOrderedCypherFluentQuery OrderByDescending(params string[] properties)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere(string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1>(Expression<Func<T1, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2>(Expression<Func<T1, T2, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3>(Expression<Func<T1, T2, T3, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4>(Expression<Func<T1, T2, T3, T4, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5>(Expression<Func<T1, T2, T3, T4, T5, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6>(Expression<Func<T1, T2, T3, T4, T5, T6, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhere<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf(bool condition, string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1>(bool condition, Expression<Func<T1, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2>(bool condition, Expression<Func<T1, T2, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3>(bool condition, Expression<Func<T1, T2, T3, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4>(bool condition, Expression<Func<T1, T2, T3, T4, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5>(bool condition, Expression<Func<T1, T2, T3, T4, T5, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery OrWhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery ParserVersion(string version)
        {
            return this;
        }

        public virtual ICypherFluentQuery ParserVersion(Version version)
        {
            return this;
        }

        public virtual ICypherFluentQuery ParserVersion(int major, int minor)
        {
            return this;
        }

        public virtual ICypherFluentQuery Planner(string planner)
        {
            return this;
        }

        public virtual ICypherFluentQuery Planner(CypherPlanner planner)
        {
            return this;
        }

        public virtual ICypherFluentQuery Remove(string removeText)
        {
            return this;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(string identity)
        {
            return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> Return<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(string identity)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery<TResult> ReturnDistinct<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
             return this as ICypherFluentQuery<TResult>;
        }

        public virtual ICypherFluentQuery Set(string setText)
        {
            return this;
        }

        public virtual ICypherFluentQuery Skip(int? skip)
        {
            return this;
        }

        public virtual ICypherFluentQuery StartDatabase(string databaseName)
        {
            return this;
        }

        public virtual ICypherFluentQuery StopDatabase(string databaseName)
        {
            return this;
        }

        public IOrderedCypherFluentQuery ThenBy(params string[] properties)
        {
            throw new NotImplementedException();
        }

        public IOrderedCypherFluentQuery ThenByDescending(params string[] properties)
        {
            throw new NotImplementedException();
        }

        public virtual ICypherFluentQuery Union()
        {
            return this;
        }

        public virtual ICypherFluentQuery UnionAll()
        {
            return this;
        }

        public virtual ICypherFluentQuery Unwind(string collection, string columnName)
        {
            return this;
        }

        public virtual ICypherFluentQuery Unwind(IEnumerable collection, string identity)
        {
            return this;
        }

        public virtual ICypherFluentQuery Use(string graphName)
        {
            return this;
        }

        public virtual ICypherFluentQuery UsingIndex(string index)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where(string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1>(Expression<Func<T1, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2>(Expression<Func<T1, T2, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3>(Expression<Func<T1, T2, T3, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4>(Expression<Func<T1, T2, T3, T4, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5>(Expression<Func<T1, T2, T3, T4, T5, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6>(Expression<Func<T1, T2, T3, T4, T5, T6, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery Where<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf(bool condition, string text)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1>(bool condition, Expression<Func<T1, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2>(bool condition, Expression<Func<T1, T2, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3>(bool condition, Expression<Func<T1, T2, T3, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4>(bool condition, Expression<Func<T1, T2, T3, T4, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5>(bool condition, Expression<Func<T1, T2, T3, T4, T5, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WhereIf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(bool condition, Expression<Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With(string withText)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, ICypherResultItem, TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery With<TResult>(Expression<Func<TResult>> expression)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithBookmark(string bookmark)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithBookmarks(params string[] bookmarks)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithDatabase(string databaseName)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithIdentifier(string identifier)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithParam(string key, object value)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithParams(IDictionary<string, object> parameters)
        {
            return this;
        }

        public virtual ICypherFluentQuery WithParams(object parameters)
        {
            return this;
        }

        public virtual ICypherFluentQuery Yield(string yieldText)
        {
            return this;
        }

        ICypherFluentQuery<TResult> ICypherFluentQuery<TResult>.Limit(int? limit)
        {
            return this;
        }

        IOrderedCypherFluentQuery<TResult> ICypherFluentQuery<TResult>.OrderBy(params string[] properties)
        {
            return (IOrderedCypherFluentQuery<TResult>)this;
        }

        IOrderedCypherFluentQuery<TResult> ICypherFluentQuery<TResult>.OrderByDescending(params string[] properties)
        {
            return (IOrderedCypherFluentQuery<TResult>)this;
        }

        ICypherFluentQuery<TResult> ICypherFluentQuery<TResult>.Skip(int? skip)
        {
            return this;
        }

        ICypherFluentQuery<TResult> ICypherFluentQuery<TResult>.Unwind(string collectionName, string columnName)
        {
            return this;
        }
    }
}
