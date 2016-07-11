﻿using System; 
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using LanguageExt;
using static LanguageExt.Prelude;
using LanguageExt.Trans;
using LanguageExt.Trans.Linq;
using System.Diagnostics.Contracts;

namespace LanguageExt
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Lst<V>> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Map<K, V>> SelectMany<T, K, U, V>(this IEnumerable<T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<TryOption<V>> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Try<V>> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Either<L, V>> SelectMany<T, L, U, V>(this IEnumerable<T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this IEnumerable<T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Reader<Env, V>> SelectMany<T, Env, U, V>(this IEnumerable<T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Writer<Out, V>> SelectMany<T, Out, U, V>(this IEnumerable<T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<State<State, V>> SelectMany<T, State, U, V>(this IEnumerable<T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this IEnumerable<T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Task<V>> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<IEnumerable<V>> SelectMany<T, U, V>(this Lst<T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Map<K, V>> SelectMany<T, K, U, V>(this Lst<T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<TryOption<V>> SelectMany<T, U, V>(this Lst<T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Try<V>> SelectMany<T, U, V>(this Lst<T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Either<L, V>> SelectMany<T, L, U, V>(this Lst<T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this Lst<T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Reader<Env, V>> SelectMany<T, Env, U, V>(this Lst<T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Writer<Out, V>> SelectMany<T, Out, U, V>(this Lst<T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<State<State, V>> SelectMany<T, State, U, V>(this Lst<T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this Lst<T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Task<V>> SelectMany<T, U, V>(this Lst<T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, IEnumerable<V>> SelectMany<K, T, U, V>(this Map<K, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Lst<V>> SelectMany<K, T, U, V>(this Map<K, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, TryOption<V>> SelectMany<K, T, U, V>(this Map<K, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Try<V>> SelectMany<K, T, U, V>(this Map<K, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Either<L, V>> SelectMany<K, T, L, U, V>(this Map<K, T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, EitherUnsafe<L, V>> SelectMany<K, T, L, U, V>(this Map<K, T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Reader<Env, V>> SelectMany<K, T, Env, U, V>(this Map<K, T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Writer<Out, V>> SelectMany<K, T, Out, U, V>(this Map<K, T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, State<State, V>> SelectMany<K, T, State, U, V>(this Map<K, T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Rws<Env, Out, State, V>> SelectMany<K, T, Env, Out, State, U, V>(this Map<K, T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Task<V>> SelectMany<K, T, U, V>(this Map<K, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<IEnumerable<V>> SelectMany<T, U, V>(this TryOption<T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Lst<V>> SelectMany<T, U, V>(this TryOption<T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Map<K, V>> SelectMany<T, K, U, V>(this TryOption<T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Try<V>> SelectMany<T, U, V>(this TryOption<T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Either<L, V>> SelectMany<T, L, U, V>(this TryOption<T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this TryOption<T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Reader<Env, V>> SelectMany<T, Env, U, V>(this TryOption<T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Writer<Out, V>> SelectMany<T, Out, U, V>(this TryOption<T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<State<State, V>> SelectMany<T, State, U, V>(this TryOption<T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this TryOption<T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Task<V>> SelectMany<T, U, V>(this TryOption<T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<IEnumerable<V>> SelectMany<T, U, V>(this Try<T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Lst<V>> SelectMany<T, U, V>(this Try<T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Map<K, V>> SelectMany<T, K, U, V>(this Try<T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<TryOption<V>> SelectMany<T, U, V>(this Try<T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Either<L, V>> SelectMany<T, L, U, V>(this Try<T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this Try<T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Reader<Env, V>> SelectMany<T, Env, U, V>(this Try<T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Writer<Out, V>> SelectMany<T, Out, U, V>(this Try<T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<State<State, V>> SelectMany<T, State, U, V>(this Try<T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this Try<T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Task<V>> SelectMany<T, U, V>(this Try<T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, IEnumerable<V>> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Lst<V>> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Map<K, V>> SelectMany<L, T, K, U, V>(this Either<L, T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, TryOption<V>> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Try<V>> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, EitherUnsafe<L, V>> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Reader<Env, V>> SelectMany<L, T, Env, U, V>(this Either<L, T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Writer<Out, V>> SelectMany<L, T, Out, U, V>(this Either<L, T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, State<State, V>> SelectMany<L, T, State, U, V>(this Either<L, T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Rws<Env, Out, State, V>> SelectMany<L, T, Env, Out, State, U, V>(this Either<L, T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Task<V>> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, IEnumerable<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Lst<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Map<K, V>> SelectMany<L, T, K, U, V>(this EitherUnsafe<L, T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, TryOption<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Try<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Either<L, V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Reader<Env, V>> SelectMany<L, T, Env, U, V>(this EitherUnsafe<L, T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Writer<Out, V>> SelectMany<L, T, Out, U, V>(this EitherUnsafe<L, T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, State<State, V>> SelectMany<L, T, State, U, V>(this EitherUnsafe<L, T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Rws<Env, Out, State, V>> SelectMany<L, T, Env, Out, State, U, V>(this EitherUnsafe<L, T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Task<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, IEnumerable<V>> SelectMany<Env, T, U, V>(this Reader<Env, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Lst<V>> SelectMany<Env, T, U, V>(this Reader<Env, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Map<K, V>> SelectMany<Env, T, K, U, V>(this Reader<Env, T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, TryOption<V>> SelectMany<Env, T, U, V>(this Reader<Env, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Try<V>> SelectMany<Env, T, U, V>(this Reader<Env, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Either<L, V>> SelectMany<Env, T, L, U, V>(this Reader<Env, T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, EitherUnsafe<L, V>> SelectMany<Env, T, L, U, V>(this Reader<Env, T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Task<V>> SelectMany<Env, T, U, V>(this Reader<Env, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, IEnumerable<V>> SelectMany<Out, T, U, V>(this Writer<Out, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Lst<V>> SelectMany<Out, T, U, V>(this Writer<Out, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Map<K, V>> SelectMany<Out, T, K, U, V>(this Writer<Out, T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, TryOption<V>> SelectMany<Out, T, U, V>(this Writer<Out, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Try<V>> SelectMany<Out, T, U, V>(this Writer<Out, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Either<L, V>> SelectMany<Out, T, L, U, V>(this Writer<Out, T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, EitherUnsafe<L, V>> SelectMany<Out, T, L, U, V>(this Writer<Out, T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Task<V>> SelectMany<Out, T, U, V>(this Writer<Out, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, IEnumerable<V>> SelectMany<State, T, U, V>(this State<State, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Lst<V>> SelectMany<State, T, U, V>(this State<State, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Map<K, V>> SelectMany<State, T, K, U, V>(this State<State, T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, TryOption<V>> SelectMany<State, T, U, V>(this State<State, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Try<V>> SelectMany<State, T, U, V>(this State<State, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Either<L, V>> SelectMany<State, T, L, U, V>(this State<State, T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, EitherUnsafe<L, V>> SelectMany<State, T, L, U, V>(this State<State, T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Task<V>> SelectMany<State, T, U, V>(this State<State, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, IEnumerable<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Lst<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Map<K, V>> SelectMany<Env, Out, State, T, K, U, V>(this Rws<Env, Out, State, T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, TryOption<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Try<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Either<L, V>> SelectMany<Env, Out, State, T, L, U, V>(this Rws<Env, Out, State, T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, EitherUnsafe<L, V>> SelectMany<Env, Out, State, T, L, U, V>(this Rws<Env, Out, State, T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Task<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, T> self, Func<T, Task<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<IEnumerable<V>> SelectMany<T, U, V>(this Task<T> self, Func<T, IEnumerable<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Lst<V>> SelectMany<T, U, V>(this Task<T> self, Func<T, Lst<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Map<K, V>> SelectMany<T, K, U, V>(this Task<T> self, Func<T, Map<K, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<TryOption<V>> SelectMany<T, U, V>(this Task<T> self, Func<T, TryOption<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Try<V>> SelectMany<T, U, V>(this Task<T> self, Func<T, Try<U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Either<L, V>> SelectMany<T, L, U, V>(this Task<T> self, Func<T, Either<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this Task<T> self, Func<T, EitherUnsafe<L, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Reader<Env, V>> SelectMany<T, Env, U, V>(this Task<T> self, Func<T, Reader<Env, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Writer<Out, V>> SelectMany<T, Out, U, V>(this Task<T> self, Func<T, Writer<Out, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<State<State, V>> SelectMany<T, State, U, V>(this Task<T> self, Func<T, State<State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this Task<T> self, Func<T, Rws<Env, Out, State, U>> bind, Func<T, U, V> project) => self.Map(t => bind(t).Map(u => project(t, u)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(IEnumerable<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(IEnumerable<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<IEnumerable<U>> bindT<T, U>(IEnumerable<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<IEnumerable<T>> filterT<T>(IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(IEnumerable<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(IEnumerable<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<IEnumerable<U>> mapT<T, U>(IEnumerable<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(IEnumerable<IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(IEnumerable<IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(IEnumerable<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(IEnumerable<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Lst<U>> bindT<T, U>(IEnumerable<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Lst<T>> filterT<T>(IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(IEnumerable<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(IEnumerable<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Lst<U>> mapT<T, U>(IEnumerable<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(IEnumerable<Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(IEnumerable<Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(IEnumerable<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, K>(IEnumerable<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Map<K, U>> bindT<T, K, U>(IEnumerable<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, K>(IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Map<K, T>> filterT<T, K>(IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, K, V>(IEnumerable<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, K>(IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, K>(IEnumerable<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Map<K, U>> mapT<T, K, U>(IEnumerable<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, K>(IEnumerable<Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(IEnumerable<Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(IEnumerable<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(IEnumerable<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<TryOption<U>> bindT<T, U>(IEnumerable<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<TryOption<T>> filterT<T>(IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(IEnumerable<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(IEnumerable<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<TryOption<U>> mapT<T, U>(IEnumerable<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(IEnumerable<TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(IEnumerable<TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(IEnumerable<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(IEnumerable<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Try<U>> bindT<T, U>(IEnumerable<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(IEnumerable<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Try<T>> filterT<T>(IEnumerable<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(IEnumerable<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(IEnumerable<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(IEnumerable<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Try<U>> mapT<T, U>(IEnumerable<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(IEnumerable<Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(IEnumerable<Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(IEnumerable<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(IEnumerable<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Either<L, U>> bindT<T, L, U>(IEnumerable<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Either<L, T>> filterT<T, L>(IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(IEnumerable<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(IEnumerable<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Either<L, U>> mapT<T, L, U>(IEnumerable<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(IEnumerable<Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(IEnumerable<Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(IEnumerable<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(IEnumerable<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<EitherUnsafe<L, U>> bindT<T, L, U>(IEnumerable<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<EitherUnsafe<L, T>> filterT<T, L>(IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(IEnumerable<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(IEnumerable<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<EitherUnsafe<L, U>> mapT<T, L, U>(IEnumerable<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(IEnumerable<EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(IEnumerable<EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(IEnumerable<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<T, Env>(IEnumerable<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Reader<Env, U>> bindT<T, Env, U>(IEnumerable<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<T, Env>(IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Reader<Env, T>> filterT<T, Env>(IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<T, Env, V>(IEnumerable<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<T, Env>(IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<T, Env>(IEnumerable<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Reader<Env, U>> mapT<T, Env, U>(IEnumerable<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<T, Env>(IEnumerable<Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(IEnumerable<Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(IEnumerable<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<T, Out>(IEnumerable<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Writer<Out, U>> bindT<T, Out, U>(IEnumerable<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<T, Out>(IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Writer<Out, T>> filterT<T, Out>(IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<T, Out, V>(IEnumerable<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<T, Out>(IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<T, Out>(IEnumerable<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Writer<Out, U>> mapT<T, Out, U>(IEnumerable<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<T, Out>(IEnumerable<Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(IEnumerable<Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(IEnumerable<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<T, State>(IEnumerable<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<State<State, U>> bindT<T, State, U>(IEnumerable<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<T, State>(IEnumerable<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<State<State, T>> filterT<T, State>(IEnumerable<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<T, State, V>(IEnumerable<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<T, State>(IEnumerable<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<T, State>(IEnumerable<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<State<State, U>> mapT<T, State, U>(IEnumerable<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<T, State>(IEnumerable<State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(IEnumerable<State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(IEnumerable<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Rws<Env, Out, State, U>> bindT<T, Env, Out, State, U>(IEnumerable<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Rws<Env, Out, State, T>> filterT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<T, Env, Out, State, V>(IEnumerable<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Rws<Env, Out, State, U>> mapT<T, Env, Out, State, U>(IEnumerable<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(IEnumerable<Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(IEnumerable<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(IEnumerable<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Task<U>> bindT<T, U>(IEnumerable<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(IEnumerable<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Task<T>> filterT<T>(IEnumerable<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(IEnumerable<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(IEnumerable<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(IEnumerable<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Task<U>> mapT<T, U>(IEnumerable<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(IEnumerable<Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(IEnumerable<Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Lst<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Lst<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<IEnumerable<U>> bindT<T, U>(Lst<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<IEnumerable<T>> filterT<T>(Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Lst<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Lst<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<IEnumerable<U>> mapT<T, U>(Lst<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Lst<IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Lst<IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Lst<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Lst<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Lst<U>> bindT<T, U>(Lst<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Lst<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Lst<T>> filterT<T>(Lst<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Lst<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Lst<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Lst<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Lst<U>> mapT<T, U>(Lst<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Lst<Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Lst<Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Lst<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, K>(Lst<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Map<K, U>> bindT<T, K, U>(Lst<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, K>(Lst<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Map<K, T>> filterT<T, K>(Lst<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, K, V>(Lst<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, K>(Lst<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, K>(Lst<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Map<K, U>> mapT<T, K, U>(Lst<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, K>(Lst<Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(Lst<Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Lst<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Lst<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<TryOption<U>> bindT<T, U>(Lst<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Lst<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<TryOption<T>> filterT<T>(Lst<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Lst<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Lst<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Lst<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<TryOption<U>> mapT<T, U>(Lst<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Lst<TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Lst<TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Lst<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Lst<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Try<U>> bindT<T, U>(Lst<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Lst<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Try<T>> filterT<T>(Lst<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Lst<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Lst<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Lst<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Try<U>> mapT<T, U>(Lst<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Lst<Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Lst<Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Lst<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(Lst<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Either<L, U>> bindT<T, L, U>(Lst<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(Lst<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Either<L, T>> filterT<T, L>(Lst<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(Lst<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(Lst<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(Lst<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Either<L, U>> mapT<T, L, U>(Lst<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(Lst<Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(Lst<Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Lst<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(Lst<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<EitherUnsafe<L, U>> bindT<T, L, U>(Lst<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<EitherUnsafe<L, T>> filterT<T, L>(Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(Lst<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(Lst<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<EitherUnsafe<L, U>> mapT<T, L, U>(Lst<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(Lst<EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(Lst<EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Lst<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<T, Env>(Lst<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Reader<Env, U>> bindT<T, Env, U>(Lst<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<T, Env>(Lst<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Reader<Env, T>> filterT<T, Env>(Lst<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<T, Env, V>(Lst<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<T, Env>(Lst<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<T, Env>(Lst<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Reader<Env, U>> mapT<T, Env, U>(Lst<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<T, Env>(Lst<Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(Lst<Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Lst<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<T, Out>(Lst<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Writer<Out, U>> bindT<T, Out, U>(Lst<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<T, Out>(Lst<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Writer<Out, T>> filterT<T, Out>(Lst<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<T, Out, V>(Lst<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<T, Out>(Lst<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<T, Out>(Lst<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Writer<Out, U>> mapT<T, Out, U>(Lst<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<T, Out>(Lst<Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(Lst<Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(Lst<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<T, State>(Lst<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<State<State, U>> bindT<T, State, U>(Lst<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<T, State>(Lst<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<State<State, T>> filterT<T, State>(Lst<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<T, State, V>(Lst<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<T, State>(Lst<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<T, State>(Lst<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<State<State, U>> mapT<T, State, U>(Lst<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<T, State>(Lst<State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(Lst<State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Lst<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Rws<Env, Out, State, U>> bindT<T, Env, Out, State, U>(Lst<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Rws<Env, Out, State, T>> filterT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<T, Env, Out, State, V>(Lst<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Rws<Env, Out, State, U>> mapT<T, Env, Out, State, U>(Lst<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(Lst<Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Lst<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Lst<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Task<U>> bindT<T, U>(Lst<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Lst<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Task<T>> filterT<T>(Lst<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Lst<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Lst<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Lst<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Task<U>> mapT<T, U>(Lst<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Lst<Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Lst<Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Map<K, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T>(Map<K, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, IEnumerable<U>> bindT<K, T, U>(Map<K, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T>(Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, IEnumerable<T>> filterT<K, T>(Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, V>(Map<K, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T>(Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T>(Map<K, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, IEnumerable<U>> mapT<K, T, U>(Map<K, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T>(Map<K, IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(Map<K, IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Map<K, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T>(Map<K, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Lst<U>> bindT<K, T, U>(Map<K, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T>(Map<K, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Lst<T>> filterT<K, T>(Map<K, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, V>(Map<K, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T>(Map<K, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T>(Map<K, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Lst<U>> mapT<K, T, U>(Map<K, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T>(Map<K, Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(Map<K, Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Map<K, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T>(Map<K, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Map<K, U>> bindT<K, T, U>(Map<K, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T>(Map<K, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Map<K, T>> filterT<K, T>(Map<K, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, V>(Map<K, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T>(Map<K, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T>(Map<K, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Map<K, U>> mapT<K, T, U>(Map<K, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T>(Map<K, Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(Map<K, Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Map<K, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T>(Map<K, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, TryOption<U>> bindT<K, T, U>(Map<K, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T>(Map<K, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, TryOption<T>> filterT<K, T>(Map<K, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, V>(Map<K, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T>(Map<K, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T>(Map<K, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, TryOption<U>> mapT<K, T, U>(Map<K, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T>(Map<K, TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(Map<K, TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Map<K, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T>(Map<K, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Try<U>> bindT<K, T, U>(Map<K, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T>(Map<K, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Try<T>> filterT<K, T>(Map<K, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, V>(Map<K, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T>(Map<K, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T>(Map<K, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Try<U>> mapT<K, T, U>(Map<K, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T>(Map<K, Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(Map<K, Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K, L>(Map<K, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T, L>(Map<K, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Either<L, U>> bindT<K, T, L, U>(Map<K, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T, L>(Map<K, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Either<L, T>> filterT<K, T, L>(Map<K, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, L, V>(Map<K, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T, L>(Map<K, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T, L>(Map<K, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Either<L, U>> mapT<K, T, L, U>(Map<K, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T, L>(Map<K, Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T, L>(Map<K, Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K, L>(Map<K, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T, L>(Map<K, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, EitherUnsafe<L, U>> bindT<K, T, L, U>(Map<K, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T, L>(Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, EitherUnsafe<L, T>> filterT<K, T, L>(Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, L, V>(Map<K, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T, L>(Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T, L>(Map<K, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, EitherUnsafe<L, U>> mapT<K, T, L, U>(Map<K, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T, L>(Map<K, EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T, L>(Map<K, EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<K, Env>(Map<K, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<K, T, Env>(Map<K, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Reader<Env, U>> bindT<K, T, Env, U>(Map<K, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<K, T, Env>(Map<K, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Reader<Env, T>> filterT<K, T, Env>(Map<K, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<K, T, Env, V>(Map<K, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<K, T, Env>(Map<K, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<K, T, Env>(Map<K, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Reader<Env, U>> mapT<K, T, Env, U>(Map<K, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<K, T, Env>(Map<K, Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<K, T, Env>(Map<K, Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<K, Out>(Map<K, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<K, T, Out>(Map<K, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Writer<Out, U>> bindT<K, T, Out, U>(Map<K, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<K, T, Out>(Map<K, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Writer<Out, T>> filterT<K, T, Out>(Map<K, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<K, T, Out, V>(Map<K, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<K, T, Out>(Map<K, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<K, T, Out>(Map<K, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Writer<Out, U>> mapT<K, T, Out, U>(Map<K, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<K, T, Out>(Map<K, Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<K, T, Out>(Map<K, Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<K, State>(Map<K, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<K, T, State>(Map<K, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, State<State, U>> bindT<K, T, State, U>(Map<K, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<K, T, State>(Map<K, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, State<State, T>> filterT<K, T, State>(Map<K, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<K, T, State, V>(Map<K, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<K, T, State>(Map<K, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<K, T, State>(Map<K, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, State<State, U>> mapT<K, T, State, U>(Map<K, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<K, T, State>(Map<K, State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<K, T, State>(Map<K, State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<K, Env, Out, State>(Map<K, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Rws<Env, Out, State, U>> bindT<K, T, Env, Out, State, U>(Map<K, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Rws<Env, Out, State, T>> filterT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<K, T, Env, Out, State, V>(Map<K, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Rws<Env, Out, State, U>> mapT<K, T, Env, Out, State, U>(Map<K, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<K, T, Env, Out, State>(Map<K, Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Map<K, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<K, T>(Map<K, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Task<U>> bindT<K, T, U>(Map<K, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<K, T>(Map<K, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Task<T>> filterT<K, T>(Map<K, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<K, T, V>(Map<K, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<K, T>(Map<K, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<K, T>(Map<K, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Task<U>> mapT<K, T, U>(Map<K, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<K, T>(Map<K, Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(Map<K, Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(TryOption<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(TryOption<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<IEnumerable<U>> bindT<T, U>(TryOption<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<IEnumerable<T>> filterT<T>(TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(TryOption<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(TryOption<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<IEnumerable<U>> mapT<T, U>(TryOption<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(TryOption<IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(TryOption<IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(TryOption<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(TryOption<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Lst<U>> bindT<T, U>(TryOption<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(TryOption<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Lst<T>> filterT<T>(TryOption<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(TryOption<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(TryOption<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(TryOption<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Lst<U>> mapT<T, U>(TryOption<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(TryOption<Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(TryOption<Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(TryOption<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, K>(TryOption<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Map<K, U>> bindT<T, K, U>(TryOption<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, K>(TryOption<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Map<K, T>> filterT<T, K>(TryOption<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, K, V>(TryOption<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, K>(TryOption<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, K>(TryOption<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Map<K, U>> mapT<T, K, U>(TryOption<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, K>(TryOption<Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(TryOption<Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(TryOption<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(TryOption<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<TryOption<U>> bindT<T, U>(TryOption<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(TryOption<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<TryOption<T>> filterT<T>(TryOption<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(TryOption<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(TryOption<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(TryOption<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<TryOption<U>> mapT<T, U>(TryOption<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(TryOption<TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(TryOption<TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(TryOption<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(TryOption<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Try<U>> bindT<T, U>(TryOption<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(TryOption<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Try<T>> filterT<T>(TryOption<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(TryOption<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(TryOption<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(TryOption<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Try<U>> mapT<T, U>(TryOption<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(TryOption<Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(TryOption<Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(TryOption<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(TryOption<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Either<L, U>> bindT<T, L, U>(TryOption<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(TryOption<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Either<L, T>> filterT<T, L>(TryOption<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(TryOption<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(TryOption<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(TryOption<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Either<L, U>> mapT<T, L, U>(TryOption<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(TryOption<Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(TryOption<Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(TryOption<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(TryOption<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<EitherUnsafe<L, U>> bindT<T, L, U>(TryOption<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<EitherUnsafe<L, T>> filterT<T, L>(TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(TryOption<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(TryOption<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<EitherUnsafe<L, U>> mapT<T, L, U>(TryOption<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(TryOption<EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(TryOption<EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(TryOption<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<T, Env>(TryOption<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Reader<Env, U>> bindT<T, Env, U>(TryOption<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<T, Env>(TryOption<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Reader<Env, T>> filterT<T, Env>(TryOption<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<T, Env, V>(TryOption<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<T, Env>(TryOption<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<T, Env>(TryOption<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Reader<Env, U>> mapT<T, Env, U>(TryOption<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<T, Env>(TryOption<Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(TryOption<Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(TryOption<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<T, Out>(TryOption<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Writer<Out, U>> bindT<T, Out, U>(TryOption<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<T, Out>(TryOption<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Writer<Out, T>> filterT<T, Out>(TryOption<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<T, Out, V>(TryOption<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<T, Out>(TryOption<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<T, Out>(TryOption<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Writer<Out, U>> mapT<T, Out, U>(TryOption<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<T, Out>(TryOption<Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(TryOption<Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(TryOption<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<T, State>(TryOption<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<State<State, U>> bindT<T, State, U>(TryOption<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<T, State>(TryOption<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<State<State, T>> filterT<T, State>(TryOption<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<T, State, V>(TryOption<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<T, State>(TryOption<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<T, State>(TryOption<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<State<State, U>> mapT<T, State, U>(TryOption<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<T, State>(TryOption<State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(TryOption<State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(TryOption<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Rws<Env, Out, State, U>> bindT<T, Env, Out, State, U>(TryOption<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Rws<Env, Out, State, T>> filterT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<T, Env, Out, State, V>(TryOption<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Rws<Env, Out, State, U>> mapT<T, Env, Out, State, U>(TryOption<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(TryOption<Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(TryOption<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(TryOption<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Task<U>> bindT<T, U>(TryOption<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(TryOption<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Task<T>> filterT<T>(TryOption<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(TryOption<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(TryOption<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(TryOption<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Task<U>> mapT<T, U>(TryOption<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(TryOption<Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(TryOption<Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Try<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Try<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<IEnumerable<U>> bindT<T, U>(Try<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Try<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<IEnumerable<T>> filterT<T>(Try<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Try<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Try<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Try<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<IEnumerable<U>> mapT<T, U>(Try<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Try<IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Try<IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Try<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Try<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Lst<U>> bindT<T, U>(Try<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Try<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Lst<T>> filterT<T>(Try<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Try<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Try<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Try<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Lst<U>> mapT<T, U>(Try<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Try<Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Try<Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Try<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, K>(Try<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Map<K, U>> bindT<T, K, U>(Try<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, K>(Try<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Map<K, T>> filterT<T, K>(Try<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, K, V>(Try<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, K>(Try<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, K>(Try<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Map<K, U>> mapT<T, K, U>(Try<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, K>(Try<Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(Try<Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Try<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Try<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<TryOption<U>> bindT<T, U>(Try<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Try<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<TryOption<T>> filterT<T>(Try<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Try<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Try<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Try<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<TryOption<U>> mapT<T, U>(Try<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Try<TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Try<TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Try<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Try<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Try<U>> bindT<T, U>(Try<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Try<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Try<T>> filterT<T>(Try<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Try<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Try<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Try<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Try<U>> mapT<T, U>(Try<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Try<Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Try<Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Try<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(Try<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Either<L, U>> bindT<T, L, U>(Try<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(Try<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Either<L, T>> filterT<T, L>(Try<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(Try<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(Try<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(Try<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Either<L, U>> mapT<T, L, U>(Try<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(Try<Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(Try<Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Try<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(Try<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<EitherUnsafe<L, U>> bindT<T, L, U>(Try<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<EitherUnsafe<L, T>> filterT<T, L>(Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(Try<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(Try<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<EitherUnsafe<L, U>> mapT<T, L, U>(Try<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(Try<EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(Try<EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Try<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<T, Env>(Try<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Reader<Env, U>> bindT<T, Env, U>(Try<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<T, Env>(Try<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Reader<Env, T>> filterT<T, Env>(Try<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<T, Env, V>(Try<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<T, Env>(Try<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<T, Env>(Try<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Reader<Env, U>> mapT<T, Env, U>(Try<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<T, Env>(Try<Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(Try<Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Try<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<T, Out>(Try<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Writer<Out, U>> bindT<T, Out, U>(Try<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<T, Out>(Try<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Writer<Out, T>> filterT<T, Out>(Try<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<T, Out, V>(Try<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<T, Out>(Try<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<T, Out>(Try<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Writer<Out, U>> mapT<T, Out, U>(Try<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<T, Out>(Try<Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(Try<Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(Try<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<T, State>(Try<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<State<State, U>> bindT<T, State, U>(Try<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<T, State>(Try<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<State<State, T>> filterT<T, State>(Try<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<T, State, V>(Try<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<T, State>(Try<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<T, State>(Try<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<State<State, U>> mapT<T, State, U>(Try<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<T, State>(Try<State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(Try<State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Try<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Rws<Env, Out, State, U>> bindT<T, Env, Out, State, U>(Try<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Rws<Env, Out, State, T>> filterT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<T, Env, Out, State, V>(Try<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Rws<Env, Out, State, U>> mapT<T, Env, Out, State, U>(Try<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(Try<Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Try<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Try<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Task<U>> bindT<T, U>(Try<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Try<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Task<T>> filterT<T>(Try<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Try<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Try<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Try<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Task<U>> mapT<T, U>(Try<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Try<Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Try<Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, IEnumerable<U>> bindT<L, T, U>(Either<L, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, IEnumerable<T>> filterT<L, T>(Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, IEnumerable<U>> mapT<L, T, U>(Either<L, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Lst<U>> bindT<L, T, U>(Either<L, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Lst<T>> filterT<L, T>(Either<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Lst<U>> mapT<L, T, U>(Either<L, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L, K>(Either<L, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T, K>(Either<L, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Map<K, U>> bindT<L, T, K, U>(Either<L, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T, K>(Either<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Map<K, T>> filterT<L, T, K>(Either<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, K, V>(Either<L, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T, K>(Either<L, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T, K>(Either<L, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Map<K, U>> mapT<L, T, K, U>(Either<L, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T, K>(Either<L, Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T, K>(Either<L, Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, TryOption<U>> bindT<L, T, U>(Either<L, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, TryOption<T>> filterT<L, T>(Either<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, TryOption<U>> mapT<L, T, U>(Either<L, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Try<U>> bindT<L, T, U>(Either<L, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Try<T>> filterT<L, T>(Either<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Try<U>> mapT<L, T, U>(Either<L, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Either<L, U>> bindT<L, T, U>(Either<L, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Either<L, T>> filterT<L, T>(Either<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Either<L, U>> mapT<L, T, U>(Either<L, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, EitherUnsafe<L, U>> bindT<L, T, U>(Either<L, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, EitherUnsafe<L, T>> filterT<L, T>(Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, EitherUnsafe<L, U>> mapT<L, T, U>(Either<L, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<L, Env>(Either<L, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<L, T, Env>(Either<L, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Reader<Env, U>> bindT<L, T, Env, U>(Either<L, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<L, T, Env>(Either<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Reader<Env, T>> filterT<L, T, Env>(Either<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<L, T, Env, V>(Either<L, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<L, T, Env>(Either<L, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<L, T, Env>(Either<L, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Reader<Env, U>> mapT<L, T, Env, U>(Either<L, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<L, T, Env>(Either<L, Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<L, T, Env>(Either<L, Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<L, Out>(Either<L, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<L, T, Out>(Either<L, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Writer<Out, U>> bindT<L, T, Out, U>(Either<L, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<L, T, Out>(Either<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Writer<Out, T>> filterT<L, T, Out>(Either<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<L, T, Out, V>(Either<L, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<L, T, Out>(Either<L, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<L, T, Out>(Either<L, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Writer<Out, U>> mapT<L, T, Out, U>(Either<L, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<L, T, Out>(Either<L, Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<L, T, Out>(Either<L, Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<L, State>(Either<L, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<L, T, State>(Either<L, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, State<State, U>> bindT<L, T, State, U>(Either<L, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<L, T, State>(Either<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, State<State, T>> filterT<L, T, State>(Either<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<L, T, State, V>(Either<L, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<L, T, State>(Either<L, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<L, T, State>(Either<L, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, State<State, U>> mapT<L, T, State, U>(Either<L, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<L, T, State>(Either<L, State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<L, T, State>(Either<L, State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<L, Env, Out, State>(Either<L, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Rws<Env, Out, State, U>> bindT<L, T, Env, Out, State, U>(Either<L, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Rws<Env, Out, State, T>> filterT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<L, T, Env, Out, State, V>(Either<L, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Rws<Env, Out, State, U>> mapT<L, T, Env, Out, State, U>(Either<L, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<L, T, Env, Out, State>(Either<L, Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Either<L, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(Either<L, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Task<U>> bindT<L, T, U>(Either<L, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(Either<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Task<T>> filterT<L, T>(Either<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(Either<L, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(Either<L, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(Either<L, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Task<U>> mapT<L, T, U>(Either<L, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(Either<L, Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(Either<L, Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, IEnumerable<U>> bindT<L, T, U>(EitherUnsafe<L, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, IEnumerable<T>> filterT<L, T>(EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, IEnumerable<U>> mapT<L, T, U>(EitherUnsafe<L, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Lst<U>> bindT<L, T, U>(EitherUnsafe<L, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Lst<T>> filterT<L, T>(EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Lst<U>> mapT<L, T, U>(EitherUnsafe<L, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L, K>(EitherUnsafe<L, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T, K>(EitherUnsafe<L, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Map<K, U>> bindT<L, T, K, U>(EitherUnsafe<L, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T, K>(EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Map<K, T>> filterT<L, T, K>(EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, K, V>(EitherUnsafe<L, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T, K>(EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T, K>(EitherUnsafe<L, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Map<K, U>> mapT<L, T, K, U>(EitherUnsafe<L, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T, K>(EitherUnsafe<L, Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T, K>(EitherUnsafe<L, Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, TryOption<U>> bindT<L, T, U>(EitherUnsafe<L, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, TryOption<T>> filterT<L, T>(EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, TryOption<U>> mapT<L, T, U>(EitherUnsafe<L, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Try<U>> bindT<L, T, U>(EitherUnsafe<L, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Try<T>> filterT<L, T>(EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Try<U>> mapT<L, T, U>(EitherUnsafe<L, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Either<L, U>> bindT<L, T, U>(EitherUnsafe<L, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Either<L, T>> filterT<L, T>(EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Either<L, U>> mapT<L, T, U>(EitherUnsafe<L, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, EitherUnsafe<L, U>> bindT<L, T, U>(EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, EitherUnsafe<L, T>> filterT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, EitherUnsafe<L, U>> mapT<L, T, U>(EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<L, Env>(EitherUnsafe<L, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Reader<Env, U>> bindT<L, T, Env, U>(EitherUnsafe<L, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Reader<Env, T>> filterT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<L, T, Env, V>(EitherUnsafe<L, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Reader<Env, U>> mapT<L, T, Env, U>(EitherUnsafe<L, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<L, T, Env>(EitherUnsafe<L, Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<L, Out>(EitherUnsafe<L, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Writer<Out, U>> bindT<L, T, Out, U>(EitherUnsafe<L, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Writer<Out, T>> filterT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<L, T, Out, V>(EitherUnsafe<L, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Writer<Out, U>> mapT<L, T, Out, U>(EitherUnsafe<L, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<L, T, Out>(EitherUnsafe<L, Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<L, State>(EitherUnsafe<L, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<L, T, State>(EitherUnsafe<L, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, State<State, U>> bindT<L, T, State, U>(EitherUnsafe<L, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<L, T, State>(EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, State<State, T>> filterT<L, T, State>(EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<L, T, State, V>(EitherUnsafe<L, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<L, T, State>(EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<L, T, State>(EitherUnsafe<L, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, State<State, U>> mapT<L, T, State, U>(EitherUnsafe<L, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<L, T, State>(EitherUnsafe<L, State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<L, T, State>(EitherUnsafe<L, State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<L, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Rws<Env, Out, State, U>> bindT<L, T, Env, Out, State, U>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Rws<Env, Out, State, T>> filterT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<L, T, Env, Out, State, V>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Rws<Env, Out, State, U>> mapT<L, T, Env, Out, State, U>(EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<L, T, Env, Out, State>(EitherUnsafe<L, Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(EitherUnsafe<L, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<L, T>(EitherUnsafe<L, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Task<U>> bindT<L, T, U>(EitherUnsafe<L, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<L, T>(EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Task<T>> filterT<L, T>(EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<L, T, V>(EitherUnsafe<L, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<L, T>(EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<L, T>(EitherUnsafe<L, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Task<U>> mapT<L, T, U>(EitherUnsafe<L, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<L, T>(EitherUnsafe<L, Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(EitherUnsafe<L, Task<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Reader<Env, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T>(Reader<Env, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, IEnumerable<U>> bindT<Env, T, U>(Reader<Env, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T>(Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, IEnumerable<T>> filterT<Env, T>(Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, V>(Reader<Env, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T>(Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T>(Reader<Env, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, IEnumerable<U>> mapT<Env, T, U>(Reader<Env, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T>(Reader<Env, IEnumerable<T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(Reader<Env, IEnumerable<T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Reader<Env, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T>(Reader<Env, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Lst<U>> bindT<Env, T, U>(Reader<Env, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T>(Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Lst<T>> filterT<Env, T>(Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, V>(Reader<Env, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T>(Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T>(Reader<Env, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Lst<U>> mapT<Env, T, U>(Reader<Env, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T>(Reader<Env, Lst<T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(Reader<Env, Lst<T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env, K>(Reader<Env, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T, K>(Reader<Env, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Map<K, U>> bindT<Env, T, K, U>(Reader<Env, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T, K>(Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Map<K, T>> filterT<Env, T, K>(Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, K, V>(Reader<Env, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T, K>(Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T, K>(Reader<Env, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Map<K, U>> mapT<Env, T, K, U>(Reader<Env, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T, K>(Reader<Env, Map<K, T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T, K>(Reader<Env, Map<K, T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Reader<Env, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T>(Reader<Env, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, TryOption<U>> bindT<Env, T, U>(Reader<Env, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T>(Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, TryOption<T>> filterT<Env, T>(Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, V>(Reader<Env, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T>(Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T>(Reader<Env, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, TryOption<U>> mapT<Env, T, U>(Reader<Env, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T>(Reader<Env, TryOption<T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(Reader<Env, TryOption<T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Reader<Env, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T>(Reader<Env, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Try<U>> bindT<Env, T, U>(Reader<Env, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T>(Reader<Env, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Try<T>> filterT<Env, T>(Reader<Env, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, V>(Reader<Env, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T>(Reader<Env, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T>(Reader<Env, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Try<U>> mapT<Env, T, U>(Reader<Env, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T>(Reader<Env, Try<T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(Reader<Env, Try<T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env, L>(Reader<Env, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T, L>(Reader<Env, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Either<L, U>> bindT<Env, T, L, U>(Reader<Env, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T, L>(Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Either<L, T>> filterT<Env, T, L>(Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, L, V>(Reader<Env, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T, L>(Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T, L>(Reader<Env, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Either<L, U>> mapT<Env, T, L, U>(Reader<Env, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T, L>(Reader<Env, Either<L, T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T, L>(Reader<Env, Either<L, T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env, L>(Reader<Env, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, EitherUnsafe<L, U>> bindT<Env, T, L, U>(Reader<Env, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, EitherUnsafe<L, T>> filterT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, L, V>(Reader<Env, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, EitherUnsafe<L, U>> mapT<Env, T, L, U>(Reader<Env, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T, L>(Reader<Env, EitherUnsafe<L, T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, int>> sumT<Env>(Reader<Env, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, int>> countT<Env, T>(Reader<Env, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, U>> bindT<Env, T, U>(Reader<Env, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, bool>> existsT<Env, T>(Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, T>> filterT<Env, T>(Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, V>> foldT<Env, T, V>(Reader<Env, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, bool>> forallT<Env, T>(Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Reader<Env, Unit>> iterT<Env, T>(Reader<Env, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, U>> mapT<Env, T, U>(Reader<Env, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<Env, T>(Reader<Env, Reader<Env, T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<Env, T>(Reader<Env, Reader<Env, T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Reader<Env, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<Env, T>(Reader<Env, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Task<U>> bindT<Env, T, U>(Reader<Env, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<Env, T>(Reader<Env, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Task<T>> filterT<Env, T>(Reader<Env, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<Env, T, V>(Reader<Env, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<Env, T>(Reader<Env, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<Env, T>(Reader<Env, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Task<U>> mapT<Env, T, U>(Reader<Env, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, T>(Reader<Env, Task<T>> self , Env liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(Reader<Env, Task<T>> self , Env liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Writer<Out, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T>(Writer<Out, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, IEnumerable<U>> bindT<Out, T, U>(Writer<Out, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T>(Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, IEnumerable<T>> filterT<Out, T>(Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, V>(Writer<Out, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T>(Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T>(Writer<Out, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, IEnumerable<U>> mapT<Out, T, U>(Writer<Out, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T>(Writer<Out, IEnumerable<T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(Writer<Out, IEnumerable<T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Writer<Out, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T>(Writer<Out, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Lst<U>> bindT<Out, T, U>(Writer<Out, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T>(Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Lst<T>> filterT<Out, T>(Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, V>(Writer<Out, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T>(Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T>(Writer<Out, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Lst<U>> mapT<Out, T, U>(Writer<Out, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T>(Writer<Out, Lst<T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(Writer<Out, Lst<T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out, K>(Writer<Out, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T, K>(Writer<Out, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Map<K, U>> bindT<Out, T, K, U>(Writer<Out, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T, K>(Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Map<K, T>> filterT<Out, T, K>(Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, K, V>(Writer<Out, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T, K>(Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T, K>(Writer<Out, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Map<K, U>> mapT<Out, T, K, U>(Writer<Out, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T, K>(Writer<Out, Map<K, T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T, K>(Writer<Out, Map<K, T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Writer<Out, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T>(Writer<Out, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, TryOption<U>> bindT<Out, T, U>(Writer<Out, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T>(Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, TryOption<T>> filterT<Out, T>(Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, V>(Writer<Out, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T>(Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T>(Writer<Out, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, TryOption<U>> mapT<Out, T, U>(Writer<Out, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T>(Writer<Out, TryOption<T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(Writer<Out, TryOption<T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Writer<Out, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T>(Writer<Out, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Try<U>> bindT<Out, T, U>(Writer<Out, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T>(Writer<Out, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Try<T>> filterT<Out, T>(Writer<Out, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, V>(Writer<Out, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T>(Writer<Out, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T>(Writer<Out, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Try<U>> mapT<Out, T, U>(Writer<Out, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T>(Writer<Out, Try<T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(Writer<Out, Try<T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out, L>(Writer<Out, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T, L>(Writer<Out, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Either<L, U>> bindT<Out, T, L, U>(Writer<Out, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T, L>(Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Either<L, T>> filterT<Out, T, L>(Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, L, V>(Writer<Out, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T, L>(Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T, L>(Writer<Out, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Either<L, U>> mapT<Out, T, L, U>(Writer<Out, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T, L>(Writer<Out, Either<L, T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T, L>(Writer<Out, Either<L, T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out, L>(Writer<Out, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, EitherUnsafe<L, U>> bindT<Out, T, L, U>(Writer<Out, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, EitherUnsafe<L, T>> filterT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, L, V>(Writer<Out, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, EitherUnsafe<L, U>> mapT<Out, T, L, U>(Writer<Out, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T, L>(Writer<Out, EitherUnsafe<L, T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, int>> sumT<Out>(Writer<Out, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, int>> countT<Out, T>(Writer<Out, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, U>> bindT<Out, T, U>(Writer<Out, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, bool>> existsT<Out, T>(Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, T>> filterT<Out, T>(Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, V>> foldT<Out, T, V>(Writer<Out, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, bool>> forallT<Out, T>(Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Writer<Out, Unit>> iterT<Out, T>(Writer<Out, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, U>> mapT<Out, T, U>(Writer<Out, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<Out, T>(Writer<Out, Writer<Out, T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<Out, T>(Writer<Out, Writer<Out, T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Writer<Out, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<Out, T>(Writer<Out, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Task<U>> bindT<Out, T, U>(Writer<Out, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<Out, T>(Writer<Out, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Task<T>> filterT<Out, T>(Writer<Out, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<Out, T, V>(Writer<Out, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<Out, T>(Writer<Out, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<Out, T>(Writer<Out, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Task<U>> mapT<Out, T, U>(Writer<Out, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Out, T>(Writer<Out, Task<T>> self )  where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(Writer<Out, Task<T>> self )  where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(State<State, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T>(State<State, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, IEnumerable<U>> bindT<State, T, U>(State<State, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T>(State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, IEnumerable<T>> filterT<State, T>(State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, V>(State<State, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T>(State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T>(State<State, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, IEnumerable<U>> mapT<State, T, U>(State<State, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T>(State<State, IEnumerable<T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(State<State, IEnumerable<T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(State<State, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T>(State<State, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Lst<U>> bindT<State, T, U>(State<State, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T>(State<State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Lst<T>> filterT<State, T>(State<State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, V>(State<State, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T>(State<State, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T>(State<State, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Lst<U>> mapT<State, T, U>(State<State, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T>(State<State, Lst<T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(State<State, Lst<T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State, K>(State<State, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T, K>(State<State, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Map<K, U>> bindT<State, T, K, U>(State<State, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T, K>(State<State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Map<K, T>> filterT<State, T, K>(State<State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, K, V>(State<State, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T, K>(State<State, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T, K>(State<State, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Map<K, U>> mapT<State, T, K, U>(State<State, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T, K>(State<State, Map<K, T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T, K>(State<State, Map<K, T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(State<State, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T>(State<State, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, TryOption<U>> bindT<State, T, U>(State<State, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T>(State<State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, TryOption<T>> filterT<State, T>(State<State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, V>(State<State, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T>(State<State, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T>(State<State, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, TryOption<U>> mapT<State, T, U>(State<State, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T>(State<State, TryOption<T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(State<State, TryOption<T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(State<State, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T>(State<State, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Try<U>> bindT<State, T, U>(State<State, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T>(State<State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Try<T>> filterT<State, T>(State<State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, V>(State<State, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T>(State<State, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T>(State<State, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Try<U>> mapT<State, T, U>(State<State, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T>(State<State, Try<T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(State<State, Try<T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State, L>(State<State, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T, L>(State<State, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Either<L, U>> bindT<State, T, L, U>(State<State, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T, L>(State<State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Either<L, T>> filterT<State, T, L>(State<State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, L, V>(State<State, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T, L>(State<State, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T, L>(State<State, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Either<L, U>> mapT<State, T, L, U>(State<State, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T, L>(State<State, Either<L, T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T, L>(State<State, Either<L, T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State, L>(State<State, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T, L>(State<State, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, EitherUnsafe<L, U>> bindT<State, T, L, U>(State<State, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T, L>(State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, EitherUnsafe<L, T>> filterT<State, T, L>(State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, L, V>(State<State, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T, L>(State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T, L>(State<State, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, EitherUnsafe<L, U>> mapT<State, T, L, U>(State<State, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T, L>(State<State, EitherUnsafe<L, T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T, L>(State<State, EitherUnsafe<L, T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, State<State, int>> sumT<State>(State<State, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, State<State, int>> countT<State, T>(State<State, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, State<State, U>> bindT<State, T, U>(State<State, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, State<State, bool>> existsT<State, T>(State<State, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, State<State, T>> filterT<State, T>(State<State, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, State<State, V>> foldT<State, T, V>(State<State, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, State<State, bool>> forallT<State, T>(State<State, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, State<State, Unit>> iterT<State, T>(State<State, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, State<State, U>> mapT<State, T, U>(State<State, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<State, T>(State<State, State<State, T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<State, T>(State<State, State<State, T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(State<State, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<State, T>(State<State, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Task<U>> bindT<State, T, U>(State<State, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<State, T>(State<State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Task<T>> filterT<State, T>(State<State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<State, T, V>(State<State, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<State, T>(State<State, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<State, T>(State<State, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Task<U>> mapT<State, T, U>(State<State, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<State, T>(State<State, Task<T>> self , State liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(State<State, Task<T>> self , State liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Rws<Env, Out, State, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, IEnumerable<U>> bindT<Env, Out, State, T, U>(Rws<Env, Out, State, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, IEnumerable<T>> filterT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, V>(Rws<Env, Out, State, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, IEnumerable<U>> mapT<Env, Out, State, T, U>(Rws<Env, Out, State, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(Rws<Env, Out, State, IEnumerable<T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Rws<Env, Out, State, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Lst<U>> bindT<Env, Out, State, T, U>(Rws<Env, Out, State, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Lst<T>> filterT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, V>(Rws<Env, Out, State, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Lst<U>> mapT<Env, Out, State, T, U>(Rws<Env, Out, State, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(Rws<Env, Out, State, Lst<T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State, K>(Rws<Env, Out, State, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Map<K, U>> bindT<Env, Out, State, T, K, U>(Rws<Env, Out, State, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Map<K, T>> filterT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, K, V>(Rws<Env, Out, State, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Map<K, U>> mapT<Env, Out, State, T, K, U>(Rws<Env, Out, State, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T, K>(Rws<Env, Out, State, Map<K, T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Rws<Env, Out, State, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, TryOption<U>> bindT<Env, Out, State, T, U>(Rws<Env, Out, State, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, TryOption<T>> filterT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, V>(Rws<Env, Out, State, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, TryOption<U>> mapT<Env, Out, State, T, U>(Rws<Env, Out, State, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(Rws<Env, Out, State, TryOption<T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Rws<Env, Out, State, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Try<U>> bindT<Env, Out, State, T, U>(Rws<Env, Out, State, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Try<T>> filterT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, V>(Rws<Env, Out, State, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Try<U>> mapT<Env, Out, State, T, U>(Rws<Env, Out, State, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(Rws<Env, Out, State, Try<T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State, L>(Rws<Env, Out, State, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Either<L, U>> bindT<Env, Out, State, T, L, U>(Rws<Env, Out, State, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Either<L, T>> filterT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, L, V>(Rws<Env, Out, State, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Either<L, U>> mapT<Env, Out, State, T, L, U>(Rws<Env, Out, State, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T, L>(Rws<Env, Out, State, Either<L, T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State, L>(Rws<Env, Out, State, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, EitherUnsafe<L, U>> bindT<Env, Out, State, T, L, U>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, EitherUnsafe<L, T>> filterT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, L, V>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, EitherUnsafe<L, U>> mapT<Env, Out, State, T, L, U>(Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T, L>(Rws<Env, Out, State, EitherUnsafe<L, T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, int>> sumT<Env, Out, State>(Rws<Env, Out, State, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, int>> countT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, U>> bindT<Env, Out, State, T, U>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, bool>> existsT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, T>> filterT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, V>> foldT<Env, Out, State, T, V>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, bool>> forallT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Rws<Env, Out, State, Unit>> iterT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, U>> mapT<Env, Out, State, T, U>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<Env, Out, State, T>(Rws<Env, Out, State, Rws<Env, Out, State, T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Rws<Env, Out, State, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Task<U>> bindT<Env, Out, State, T, U>(Rws<Env, Out, State, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Task<T>> filterT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<Env, Out, State, T, V>(Rws<Env, Out, State, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Task<U>> mapT<Env, Out, State, T, U>(Rws<Env, Out, State, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self , Tuple<Env,State> liftArg)  where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(Rws<Env, Out, State, Task<T>> self , Tuple<Env,State> liftArg)  where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Task<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Task<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<IEnumerable<U>> bindT<T, U>(Task<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Task<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<IEnumerable<T>> filterT<T>(Task<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Task<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Task<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Task<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<IEnumerable<U>> mapT<T, U>(Task<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Task<IEnumerable<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Task<IEnumerable<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Task<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Task<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Lst<U>> bindT<T, U>(Task<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Task<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Lst<T>> filterT<T>(Task<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Task<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Task<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Task<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Lst<U>> mapT<T, U>(Task<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Task<Lst<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Task<Lst<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<K>(Task<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, K>(Task<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Map<K, U>> bindT<T, K, U>(Task<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, K>(Task<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Map<K, T>> filterT<T, K>(Task<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, K, V>(Task<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, K>(Task<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, K>(Task<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Map<K, U>> mapT<T, K, U>(Task<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, K>(Task<Map<K, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(Task<Map<K, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Task<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Task<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<TryOption<U>> bindT<T, U>(Task<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Task<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<TryOption<T>> filterT<T>(Task<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Task<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Task<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Task<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<TryOption<U>> mapT<T, U>(Task<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Task<TryOption<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Task<TryOption<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Task<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Task<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Try<U>> bindT<T, U>(Task<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Task<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Try<T>> filterT<T>(Task<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Task<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Task<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Task<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Try<U>> mapT<T, U>(Task<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Task<Try<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Task<Try<T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Task<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(Task<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Either<L, U>> bindT<T, L, U>(Task<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(Task<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Either<L, T>> filterT<T, L>(Task<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(Task<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(Task<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(Task<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Either<L, U>> mapT<T, L, U>(Task<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(Task<Either<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(Task<Either<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT<L>(Task<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T, L>(Task<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<EitherUnsafe<L, U>> bindT<T, L, U>(Task<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T, L>(Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<EitherUnsafe<L, T>> filterT<T, L>(Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, L, V>(Task<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T, L>(Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T, L>(Task<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<EitherUnsafe<L, U>> mapT<T, L, U>(Task<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T, L>(Task<EitherUnsafe<L, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(Task<EitherUnsafe<L, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> sumT<Env>(Task<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> countT<T, Env>(Task<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Reader<Env, U>> bindT<T, Env, U>(Task<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> existsT<T, Env>(Task<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Reader<Env, T>> filterT<T, Env>(Task<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> foldT<T, Env, V>(Task<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> forallT<T, Env>(Task<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> iterT<T, Env>(Task<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Reader<Env, U>> mapT<T, Env, U>(Task<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> liftT<T, Env>(Task<Reader<Env, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(Task<Reader<Env, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> sumT<Out>(Task<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> countT<T, Out>(Task<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Writer<Out, U>> bindT<T, Out, U>(Task<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> existsT<T, Out>(Task<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Writer<Out, T>> filterT<T, Out>(Task<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> foldT<T, Out, V>(Task<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> forallT<T, Out>(Task<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> iterT<T, Out>(Task<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Writer<Out, U>> mapT<T, Out, U>(Task<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> liftT<T, Out>(Task<Writer<Out, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(Task<Writer<Out, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> sumT<State>(Task<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> countT<T, State>(Task<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<State<State, U>> bindT<T, State, U>(Task<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> existsT<T, State>(Task<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<State<State, T>> filterT<T, State>(Task<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> foldT<T, State, V>(Task<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> forallT<T, State>(Task<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> iterT<T, State>(Task<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<State<State, U>> mapT<T, State, U>(Task<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> liftT<T, State>(Task<State<State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(Task<State<State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> sumT<Env, Out, State>(Task<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> countT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Rws<Env, Out, State, U>> bindT<T, Env, Out, State, U>(Task<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> existsT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Rws<Env, Out, State, T>> filterT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> foldT<T, Env, Out, State, V>(Task<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> forallT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> iterT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Rws<Env, Out, State, U>> mapT<T, Env, Out, State, U>(Task<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> liftT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(Task<Rws<Env, Out, State, T>> self )  where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskT {
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int sumT(Task<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int countT<T>(Task<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Task<U>> bindT<T, U>(Task<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool existsT<T>(Task<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Task<T>> filterT<T>(Task<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V foldT<T, V>(Task<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool forallT<T>(Task<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit iterT<T>(Task<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Task<U>> mapT<T, U>(Task<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T liftT<T>(Task<Task<T>> self )  where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(Task<Task<T>> self )  where T : class => self.ValueT();
    }
}

namespace LanguageExt.Trans
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListMonad {
        internal static T InnerValue<T>(this IEnumerable<T> self) => self.FirstOrDefault();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT(this IEnumerable<int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<T>(this IEnumerable<T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static IEnumerable<U> BindT<T, U>(this IEnumerable<T> self, Func<T, IEnumerable<U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<T>(this IEnumerable<T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static IEnumerable<T> FilterT<T>(this IEnumerable<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<T, V>(this IEnumerable<T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<T>(this IEnumerable<T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<T>(this IEnumerable<T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static IEnumerable<U> MapT<T, U>(this IEnumerable<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<T>(this IEnumerable<T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<T>(this IEnumerable<T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListMonad {
        internal static T InnerValue<T>(this Lst<T> self) => self.FirstOrDefault();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT(this Lst<int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<T>(this Lst<T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Lst<U> BindT<T, U>(this Lst<T> self, Func<T, Lst<U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<T>(this Lst<T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Lst<T> FilterT<T>(this Lst<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<T, V>(this Lst<T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<T>(this Lst<T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<T>(this Lst<T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Lst<U> MapT<T, U>(this Lst<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<T>(this Lst<T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<T>(this Lst<T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapMonad {
        internal static T InnerValue<K, T>(this Map<K, T> self) => self.Values.FirstOrDefault();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT<K>(this Map<K, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<K, T>(this Map<K, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Map<K, U> BindT<K, T, U>(this Map<K, T> self, Func<T, Map<K, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<K, T>(this Map<K, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Map<K, T> FilterT<K, T>(this Map<K, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<K, T, V>(this Map<K, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<K, T>(this Map<K, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<K, T>(this Map<K, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Map<K, U> MapT<K, T, U>(this Map<K, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<K, T>(this Map<K, T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<K, T>(this Map<K, T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionMonad {
        internal static T InnerValue<T>(this TryOption<T> self) => self.Try().Value.IfNone(default(T));
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT(this TryOption<int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<T>(this TryOption<T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static TryOption<U> BindT<T, U>(this TryOption<T> self, Func<T, TryOption<U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<T>(this TryOption<T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static TryOption<T> FilterT<T>(this TryOption<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<T, V>(this TryOption<T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<T>(this TryOption<T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<T>(this TryOption<T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static TryOption<U> MapT<T, U>(this TryOption<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<T>(this TryOption<T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<T>(this TryOption<T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryMonad {
        internal static T InnerValue<T>(this Try<T> self) => self.Try().Value;
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT(this Try<int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<T>(this Try<T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Try<U> BindT<T, U>(this Try<T> self, Func<T, Try<U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<T>(this Try<T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Try<T> FilterT<T>(this Try<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<T, V>(this Try<T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<T>(this Try<T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<T>(this Try<T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Try<U> MapT<T, U>(this Try<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<T>(this Try<T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<T>(this Try<T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherMonad {
        internal static T InnerValue<L, T>(this Either<L, T> self) => self.IsRight ? self.RightValue : default(T);
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT<L>(this Either<L, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<L, T>(this Either<L, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Either<L, U> BindT<L, T, U>(this Either<L, T> self, Func<T, Either<L, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<L, T>(this Either<L, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Either<L, T> FilterT<L, T>(this Either<L, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<L, T, V>(this Either<L, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<L, T>(this Either<L, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<L, T>(this Either<L, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Either<L, U> MapT<L, T, U>(this Either<L, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<L, T>(this Either<L, T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<L, T>(this Either<L, T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeMonad {
        internal static T InnerValue<L, T>(this EitherUnsafe<L, T> self) => self.IsRight ? self.RightValue : default(T);
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT<L>(this EitherUnsafe<L, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<L, T>(this EitherUnsafe<L, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static EitherUnsafe<L, U> BindT<L, T, U>(this EitherUnsafe<L, T> self, Func<T, EitherUnsafe<L, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<L, T>(this EitherUnsafe<L, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static EitherUnsafe<L, T> FilterT<L, T>(this EitherUnsafe<L, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<L, T, V>(this EitherUnsafe<L, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<L, T>(this EitherUnsafe<L, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<L, T>(this EitherUnsafe<L, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static EitherUnsafe<L, U> MapT<L, T, U>(this EitherUnsafe<L, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<L, T>(this EitherUnsafe<L, T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<L, T>(this EitherUnsafe<L, T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderMonad {
        internal static Reader<Env, T> InnerValue<Env, T>(this Reader<Env, T> self) => self;
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static Reader<Env, int> SumT<Env>(this Reader<Env, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static Reader<Env, int> CountT<Env, T>(this Reader<Env, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Reader<Env, U> BindT<Env, T, U>(this Reader<Env, T> self, Func<T, Reader<Env, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static Reader<Env, bool> ExistsT<Env, T>(this Reader<Env, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Reader<Env, T> FilterT<Env, T>(this Reader<Env, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static Reader<Env, V> FoldT<Env, T, V>(this Reader<Env, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static Reader<Env, bool> ForAllT<Env, T>(this Reader<Env, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Reader<Env, Unit> IterT<Env, T>(this Reader<Env, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Reader<Env, U> MapT<Env, T, U>(this Reader<Env, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<Env, T>(this Reader<Env, T> self , Env liftArg) where T : struct => self.InnerValue()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<Env, T>(this Reader<Env, T> self , Env liftArg) where T : class => self.InnerValue()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterMonad {
        internal static Writer<Out, T> InnerValue<Out, T>(this Writer<Out, T> self) => self;
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static Writer<Out, int> SumT<Out>(this Writer<Out, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static Writer<Out, int> CountT<Out, T>(this Writer<Out, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Writer<Out, U> BindT<Out, T, U>(this Writer<Out, T> self, Func<T, Writer<Out, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static Writer<Out, bool> ExistsT<Out, T>(this Writer<Out, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Writer<Out, T> FilterT<Out, T>(this Writer<Out, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static Writer<Out, V> FoldT<Out, T, V>(this Writer<Out, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static Writer<Out, bool> ForAllT<Out, T>(this Writer<Out, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Writer<Out, Unit> IterT<Out, T>(this Writer<Out, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Writer<Out, U> MapT<Out, T, U>(this Writer<Out, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<Out, T>(this Writer<Out, T> self ) where T : struct => self.InnerValue()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<Out, T>(this Writer<Out, T> self ) where T : class => self.InnerValue()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateMonad {
        internal static State<State, T> InnerValue<State, T>(this State<State, T> self) => self;
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static State<State, int> SumT<State>(this State<State, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static State<State, int> CountT<State, T>(this State<State, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static State<State, U> BindT<State, T, U>(this State<State, T> self, Func<T, State<State, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static State<State, bool> ExistsT<State, T>(this State<State, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static State<State, T> FilterT<State, T>(this State<State, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static State<State, V> FoldT<State, T, V>(this State<State, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static State<State, bool> ForAllT<State, T>(this State<State, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static State<State, Unit> IterT<State, T>(this State<State, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static State<State, U> MapT<State, T, U>(this State<State, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<State, T>(this State<State, T> self , State liftArg) where T : struct => self.InnerValue()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<State, T>(this State<State, T> self , State liftArg) where T : class => self.InnerValue()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsMonad {
        internal static Rws<Env, Out, State, T> InnerValue<Env, Out, State, T>(this Rws<Env, Out, State, T> self) => self;
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Rws<Env, Out, State, int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, int> CountT<Env, Out, State, T>(this Rws<Env, Out, State, T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, U> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, T> self, Func<T, Rws<Env, Out, State, U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, T> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T>(this Rws<Env, Out, State, T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Rws<Env, Out, State, U> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<Env, Out, State, T>(this Rws<Env, Out, State, T> self , Tuple<Env,State> liftArg) where T : struct => self.InnerValue()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<Env, Out, State, T>(this Rws<Env, Out, State, T> self , Tuple<Env,State> liftArg) where T : class => self.InnerValue()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskMonad {
        internal static T InnerValue<T>(this Task<T> self) => self.Result;
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] internal static int SumT(this Task<int> self) => self.Sum();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] internal static int CountT<T>(this Task<T> self) => self.Count();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] internal static Task<U> BindT<T, U>(this Task<T> self, Func<T, Task<U>> binder) => self.Bind(binder);
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] internal static bool ExistsT<T>(this Task<T> self, Func<T, bool> pred) => self.Exists(pred);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] internal static Task<T> FilterT<T>(this Task<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] internal static V FoldT<T, V>(this Task<T> self, V state, Func<V, T, V> fold) => self.Fold(state,fold);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] internal static bool ForAllT<T>(this Task<T> self, Func<T, bool> pred) => self.ForAll(pred);
        /// <summary>
        /// Iter
        /// </summary>
        internal static Unit IterT<T>(this Task<T> self, Action<T> action) => self.Iter(action);
        /// <summary>
        /// Map
        /// </summary>
        [Pure] internal static Task<U> MapT<T, U>(this Task<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T Lift<T>(this Task<T> self ) where T : struct => self.InnerValue();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafe<T>(this Task<T> self ) where T : class => self.InnerValue();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this IEnumerable<IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this IEnumerable<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this IEnumerable<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<IEnumerable<U>> BindT<T, U>(this IEnumerable<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<IEnumerable<T>> FilterT<T>(this IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this IEnumerable<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this IEnumerable<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<IEnumerable<U>> MapT<T, U>(this IEnumerable<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this IEnumerable<IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this IEnumerable<IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this IEnumerable<Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this IEnumerable<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this IEnumerable<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Lst<U>> BindT<T, U>(this IEnumerable<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Lst<T>> FilterT<T>(this IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this IEnumerable<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this IEnumerable<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Lst<U>> MapT<T, U>(this IEnumerable<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this IEnumerable<Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this IEnumerable<Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T, K>(this IEnumerable<Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this IEnumerable<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, K>(this IEnumerable<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Map<K, U>> BindT<T, K, U>(this IEnumerable<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, K>(this IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Map<K, T>> FilterT<T, K>(this IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, K, V>(this IEnumerable<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, K>(this IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, K>(this IEnumerable<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Map<K, U>> MapT<T, K, U>(this IEnumerable<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, K>(this IEnumerable<Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(this IEnumerable<Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this IEnumerable<TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this IEnumerable<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this IEnumerable<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<TryOption<U>> BindT<T, U>(this IEnumerable<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<TryOption<T>> FilterT<T>(this IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this IEnumerable<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this IEnumerable<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<TryOption<U>> MapT<T, U>(this IEnumerable<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this IEnumerable<TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this IEnumerable<TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this IEnumerable<Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this IEnumerable<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this IEnumerable<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Try<U>> BindT<T, U>(this IEnumerable<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this IEnumerable<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Try<T>> FilterT<T>(this IEnumerable<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this IEnumerable<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this IEnumerable<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this IEnumerable<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Try<U>> MapT<T, U>(this IEnumerable<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this IEnumerable<Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this IEnumerable<Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T, L>(this IEnumerable<Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this IEnumerable<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this IEnumerable<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Either<L, U>> BindT<T, L, U>(this IEnumerable<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Either<L, T>> FilterT<T, L>(this IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this IEnumerable<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this IEnumerable<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Either<L, U>> MapT<T, L, U>(this IEnumerable<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this IEnumerable<Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this IEnumerable<Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this IEnumerable<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<EitherUnsafe<L, U>> BindT<T, L, U>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<EitherUnsafe<L, T>> FilterT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this IEnumerable<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<EitherUnsafe<L, U>> MapT<T, L, U>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this IEnumerable<EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static Reader<Env, T> ValueT<T, Env>(this IEnumerable<Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this IEnumerable<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<T, Env>(this IEnumerable<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Reader<Env, U>> BindT<T, Env, U>(this IEnumerable<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<T, Env>(this IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Reader<Env, T>> FilterT<T, Env>(this IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<T, Env, V>(this IEnumerable<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<T, Env>(this IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<T, Env>(this IEnumerable<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Reader<Env, U>> MapT<T, Env, U>(this IEnumerable<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<T, Env>(this IEnumerable<Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(this IEnumerable<Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static Writer<Out, T> ValueT<T, Out>(this IEnumerable<Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this IEnumerable<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<T, Out>(this IEnumerable<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Writer<Out, U>> BindT<T, Out, U>(this IEnumerable<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<T, Out>(this IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Writer<Out, T>> FilterT<T, Out>(this IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<T, Out, V>(this IEnumerable<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<T, Out>(this IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<T, Out>(this IEnumerable<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Writer<Out, U>> MapT<T, Out, U>(this IEnumerable<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<T, Out>(this IEnumerable<Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(this IEnumerable<Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static State<State, T> ValueT<T, State>(this IEnumerable<State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this IEnumerable<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<T, State>(this IEnumerable<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<State<State, U>> BindT<T, State, U>(this IEnumerable<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<T, State>(this IEnumerable<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<State<State, T>> FilterT<T, State>(this IEnumerable<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<T, State, V>(this IEnumerable<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<T, State>(this IEnumerable<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<T, State>(this IEnumerable<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<State<State, U>> MapT<T, State, U>(this IEnumerable<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<T, State>(this IEnumerable<State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(this IEnumerable<State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this IEnumerable<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Rws<Env, Out, State, U>> BindT<T, Env, Out, State, U>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Rws<Env, Out, State, T>> FilterT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<T, Env, Out, State, V>(this IEnumerable<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Rws<Env, Out, State, U>> MapT<T, Env, Out, State, U>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this IEnumerable<Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this IEnumerable<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this IEnumerable<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static IEnumerable<Task<U>> BindT<T, U>(this IEnumerable<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this IEnumerable<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static IEnumerable<Task<T>> FilterT<T>(this IEnumerable<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this IEnumerable<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this IEnumerable<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this IEnumerable<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static IEnumerable<Task<U>> MapT<T, U>(this IEnumerable<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this IEnumerable<Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this IEnumerable<Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this Lst<IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Lst<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Lst<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<IEnumerable<U>> BindT<T, U>(this Lst<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<IEnumerable<T>> FilterT<T>(this Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Lst<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Lst<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<IEnumerable<U>> MapT<T, U>(this Lst<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Lst<IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Lst<IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this Lst<Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Lst<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Lst<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Lst<U>> BindT<T, U>(this Lst<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Lst<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Lst<T>> FilterT<T>(this Lst<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Lst<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Lst<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Lst<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Lst<U>> MapT<T, U>(this Lst<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Lst<Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Lst<Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T, K>(this Lst<Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Lst<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, K>(this Lst<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Map<K, U>> BindT<T, K, U>(this Lst<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, K>(this Lst<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Map<K, T>> FilterT<T, K>(this Lst<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, K, V>(this Lst<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, K>(this Lst<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, K>(this Lst<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Map<K, U>> MapT<T, K, U>(this Lst<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, K>(this Lst<Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(this Lst<Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this Lst<TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Lst<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Lst<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<TryOption<U>> BindT<T, U>(this Lst<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Lst<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<TryOption<T>> FilterT<T>(this Lst<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Lst<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Lst<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Lst<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<TryOption<U>> MapT<T, U>(this Lst<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Lst<TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Lst<TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this Lst<Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Lst<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Lst<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Try<U>> BindT<T, U>(this Lst<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Lst<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Try<T>> FilterT<T>(this Lst<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Lst<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Lst<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Lst<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Try<U>> MapT<T, U>(this Lst<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Lst<Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Lst<Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T, L>(this Lst<Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Lst<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this Lst<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Either<L, U>> BindT<T, L, U>(this Lst<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this Lst<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Either<L, T>> FilterT<T, L>(this Lst<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this Lst<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this Lst<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this Lst<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Either<L, U>> MapT<T, L, U>(this Lst<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this Lst<Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this Lst<Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T, L>(this Lst<EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Lst<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this Lst<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<EitherUnsafe<L, U>> BindT<T, L, U>(this Lst<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<EitherUnsafe<L, T>> FilterT<T, L>(this Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this Lst<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this Lst<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<EitherUnsafe<L, U>> MapT<T, L, U>(this Lst<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this Lst<EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this Lst<EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static Reader<Env, T> ValueT<T, Env>(this Lst<Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Lst<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<T, Env>(this Lst<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Reader<Env, U>> BindT<T, Env, U>(this Lst<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<T, Env>(this Lst<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Reader<Env, T>> FilterT<T, Env>(this Lst<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<T, Env, V>(this Lst<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<T, Env>(this Lst<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<T, Env>(this Lst<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Reader<Env, U>> MapT<T, Env, U>(this Lst<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<T, Env>(this Lst<Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(this Lst<Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static Writer<Out, T> ValueT<T, Out>(this Lst<Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Lst<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<T, Out>(this Lst<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Writer<Out, U>> BindT<T, Out, U>(this Lst<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<T, Out>(this Lst<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Writer<Out, T>> FilterT<T, Out>(this Lst<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<T, Out, V>(this Lst<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<T, Out>(this Lst<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<T, Out>(this Lst<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Writer<Out, U>> MapT<T, Out, U>(this Lst<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<T, Out>(this Lst<Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(this Lst<Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static State<State, T> ValueT<T, State>(this Lst<State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this Lst<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<T, State>(this Lst<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<State<State, U>> BindT<T, State, U>(this Lst<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<T, State>(this Lst<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<State<State, T>> FilterT<T, State>(this Lst<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<T, State, V>(this Lst<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<T, State>(this Lst<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<T, State>(this Lst<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<State<State, U>> MapT<T, State, U>(this Lst<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<T, State>(this Lst<State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(this Lst<State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Lst<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Rws<Env, Out, State, U>> BindT<T, Env, Out, State, U>(this Lst<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Rws<Env, Out, State, T>> FilterT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<T, Env, Out, State, V>(this Lst<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Rws<Env, Out, State, U>> MapT<T, Env, Out, State, U>(this Lst<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        internal static T ValueT<T>(this Lst<Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Lst<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Lst<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Lst<Task<U>> BindT<T, U>(this Lst<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Lst<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Lst<Task<T>> FilterT<T>(this Lst<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Lst<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Lst<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Lst<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Lst<Task<U>> MapT<T, U>(this Lst<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Lst<Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Lst<Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T>(this Map<K, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Map<K, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T>(this Map<K, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, IEnumerable<U>> BindT<K, T, U>(this Map<K, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T>(this Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, IEnumerable<T>> FilterT<K, T>(this Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, V>(this Map<K, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T>(this Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T>(this Map<K, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, IEnumerable<U>> MapT<K, T, U>(this Map<K, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T>(this Map<K, IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(this Map<K, IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T>(this Map<K, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Map<K, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T>(this Map<K, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Lst<U>> BindT<K, T, U>(this Map<K, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T>(this Map<K, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Lst<T>> FilterT<K, T>(this Map<K, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, V>(this Map<K, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T>(this Map<K, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T>(this Map<K, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Lst<U>> MapT<K, T, U>(this Map<K, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T>(this Map<K, Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(this Map<K, Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T>(this Map<K, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Map<K, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T>(this Map<K, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Map<K, U>> BindT<K, T, U>(this Map<K, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T>(this Map<K, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Map<K, T>> FilterT<K, T>(this Map<K, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, V>(this Map<K, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T>(this Map<K, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T>(this Map<K, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Map<K, U>> MapT<K, T, U>(this Map<K, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T>(this Map<K, Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(this Map<K, Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T>(this Map<K, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Map<K, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T>(this Map<K, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, TryOption<U>> BindT<K, T, U>(this Map<K, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T>(this Map<K, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, TryOption<T>> FilterT<K, T>(this Map<K, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, V>(this Map<K, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T>(this Map<K, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T>(this Map<K, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, TryOption<U>> MapT<K, T, U>(this Map<K, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T>(this Map<K, TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(this Map<K, TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T>(this Map<K, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Map<K, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T>(this Map<K, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Try<U>> BindT<K, T, U>(this Map<K, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T>(this Map<K, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Try<T>> FilterT<K, T>(this Map<K, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, V>(this Map<K, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T>(this Map<K, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T>(this Map<K, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Try<U>> MapT<K, T, U>(this Map<K, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T>(this Map<K, Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(this Map<K, Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T, L>(this Map<K, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K, L>(this Map<K, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T, L>(this Map<K, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Either<L, U>> BindT<K, T, L, U>(this Map<K, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T, L>(this Map<K, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Either<L, T>> FilterT<K, T, L>(this Map<K, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, L, V>(this Map<K, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T, L>(this Map<K, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T, L>(this Map<K, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Either<L, U>> MapT<K, T, L, U>(this Map<K, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T, L>(this Map<K, Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T, L>(this Map<K, Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K, L>(this Map<K, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, EitherUnsafe<L, U>> BindT<K, T, L, U>(this Map<K, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, EitherUnsafe<L, T>> FilterT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, L, V>(this Map<K, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, EitherUnsafe<L, U>> MapT<K, T, L, U>(this Map<K, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T, L>(this Map<K, EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static Reader<Env, T> ValueT<K, T, Env>(this Map<K, Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<K, Env>(this Map<K, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<K, T, Env>(this Map<K, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Reader<Env, U>> BindT<K, T, Env, U>(this Map<K, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<K, T, Env>(this Map<K, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Reader<Env, T>> FilterT<K, T, Env>(this Map<K, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<K, T, Env, V>(this Map<K, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<K, T, Env>(this Map<K, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<K, T, Env>(this Map<K, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Reader<Env, U>> MapT<K, T, Env, U>(this Map<K, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<K, T, Env>(this Map<K, Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<K, T, Env>(this Map<K, Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static Writer<Out, T> ValueT<K, T, Out>(this Map<K, Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<K, Out>(this Map<K, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<K, T, Out>(this Map<K, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Writer<Out, U>> BindT<K, T, Out, U>(this Map<K, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<K, T, Out>(this Map<K, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Writer<Out, T>> FilterT<K, T, Out>(this Map<K, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<K, T, Out, V>(this Map<K, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<K, T, Out>(this Map<K, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<K, T, Out>(this Map<K, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Writer<Out, U>> MapT<K, T, Out, U>(this Map<K, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<K, T, Out>(this Map<K, Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<K, T, Out>(this Map<K, Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static State<State, T> ValueT<K, T, State>(this Map<K, State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<K, State>(this Map<K, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<K, T, State>(this Map<K, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, State<State, U>> BindT<K, T, State, U>(this Map<K, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<K, T, State>(this Map<K, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, State<State, T>> FilterT<K, T, State>(this Map<K, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<K, T, State, V>(this Map<K, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<K, T, State>(this Map<K, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<K, T, State>(this Map<K, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, State<State, U>> MapT<K, T, State, U>(this Map<K, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<K, T, State>(this Map<K, State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<K, T, State>(this Map<K, State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<K, Env, Out, State>(this Map<K, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Rws<Env, Out, State, U>> BindT<K, T, Env, Out, State, U>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Rws<Env, Out, State, T>> FilterT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<K, T, Env, Out, State, V>(this Map<K, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Rws<Env, Out, State, U>> MapT<K, T, Env, Out, State, U>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        internal static T ValueT<K, T>(this Map<K, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Map<K, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<K, T>(this Map<K, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Map<K, Task<U>> BindT<K, T, U>(this Map<K, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<K, T>(this Map<K, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Map<K, Task<T>> FilterT<K, T>(this Map<K, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<K, T, V>(this Map<K, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<K, T>(this Map<K, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<K, T>(this Map<K, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Map<K, Task<U>> MapT<K, T, U>(this Map<K, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<K, T>(this Map<K, Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<K, T>(this Map<K, Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T>(this TryOption<IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this TryOption<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this TryOption<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<IEnumerable<U>> BindT<T, U>(this TryOption<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<IEnumerable<T>> FilterT<T>(this TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this TryOption<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this TryOption<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<IEnumerable<U>> MapT<T, U>(this TryOption<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this TryOption<IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this TryOption<IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T>(this TryOption<Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this TryOption<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this TryOption<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Lst<U>> BindT<T, U>(this TryOption<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this TryOption<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Lst<T>> FilterT<T>(this TryOption<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this TryOption<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this TryOption<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this TryOption<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Lst<U>> MapT<T, U>(this TryOption<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this TryOption<Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this TryOption<Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T, K>(this TryOption<Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this TryOption<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, K>(this TryOption<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Map<K, U>> BindT<T, K, U>(this TryOption<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, K>(this TryOption<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Map<K, T>> FilterT<T, K>(this TryOption<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, K, V>(this TryOption<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, K>(this TryOption<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, K>(this TryOption<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Map<K, U>> MapT<T, K, U>(this TryOption<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, K>(this TryOption<Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(this TryOption<Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T>(this TryOption<TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this TryOption<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this TryOption<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<TryOption<U>> BindT<T, U>(this TryOption<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this TryOption<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<TryOption<T>> FilterT<T>(this TryOption<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this TryOption<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this TryOption<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this TryOption<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<TryOption<U>> MapT<T, U>(this TryOption<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this TryOption<TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this TryOption<TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T>(this TryOption<Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this TryOption<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this TryOption<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Try<U>> BindT<T, U>(this TryOption<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this TryOption<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Try<T>> FilterT<T>(this TryOption<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this TryOption<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this TryOption<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this TryOption<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Try<U>> MapT<T, U>(this TryOption<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this TryOption<Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this TryOption<Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T, L>(this TryOption<Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this TryOption<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this TryOption<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Either<L, U>> BindT<T, L, U>(this TryOption<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this TryOption<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Either<L, T>> FilterT<T, L>(this TryOption<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this TryOption<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this TryOption<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this TryOption<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Either<L, U>> MapT<T, L, U>(this TryOption<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this TryOption<Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this TryOption<Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T, L>(this TryOption<EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this TryOption<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this TryOption<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<EitherUnsafe<L, U>> BindT<T, L, U>(this TryOption<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<EitherUnsafe<L, T>> FilterT<T, L>(this TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this TryOption<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this TryOption<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<EitherUnsafe<L, U>> MapT<T, L, U>(this TryOption<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this TryOption<EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this TryOption<EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static Reader<Env, T> ValueT<T, Env>(this TryOption<Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this TryOption<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<T, Env>(this TryOption<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Reader<Env, U>> BindT<T, Env, U>(this TryOption<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<T, Env>(this TryOption<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Reader<Env, T>> FilterT<T, Env>(this TryOption<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<T, Env, V>(this TryOption<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<T, Env>(this TryOption<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<T, Env>(this TryOption<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Reader<Env, U>> MapT<T, Env, U>(this TryOption<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<T, Env>(this TryOption<Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(this TryOption<Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static Writer<Out, T> ValueT<T, Out>(this TryOption<Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this TryOption<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<T, Out>(this TryOption<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Writer<Out, U>> BindT<T, Out, U>(this TryOption<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<T, Out>(this TryOption<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Writer<Out, T>> FilterT<T, Out>(this TryOption<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<T, Out, V>(this TryOption<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<T, Out>(this TryOption<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<T, Out>(this TryOption<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Writer<Out, U>> MapT<T, Out, U>(this TryOption<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<T, Out>(this TryOption<Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(this TryOption<Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static State<State, T> ValueT<T, State>(this TryOption<State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this TryOption<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<T, State>(this TryOption<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<State<State, U>> BindT<T, State, U>(this TryOption<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<T, State>(this TryOption<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<State<State, T>> FilterT<T, State>(this TryOption<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<T, State, V>(this TryOption<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<T, State>(this TryOption<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<T, State>(this TryOption<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<State<State, U>> MapT<T, State, U>(this TryOption<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<T, State>(this TryOption<State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(this TryOption<State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this TryOption<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Rws<Env, Out, State, U>> BindT<T, Env, Out, State, U>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Rws<Env, Out, State, T>> FilterT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<T, Env, Out, State, V>(this TryOption<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Rws<Env, Out, State, U>> MapT<T, Env, Out, State, U>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        internal static T ValueT<T>(this TryOption<Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this TryOption<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this TryOption<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static TryOption<Task<U>> BindT<T, U>(this TryOption<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this TryOption<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static TryOption<Task<T>> FilterT<T>(this TryOption<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this TryOption<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this TryOption<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this TryOption<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static TryOption<Task<U>> MapT<T, U>(this TryOption<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this TryOption<Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this TryOption<Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T>(this Try<IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Try<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Try<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<IEnumerable<U>> BindT<T, U>(this Try<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Try<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<IEnumerable<T>> FilterT<T>(this Try<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Try<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Try<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Try<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<IEnumerable<U>> MapT<T, U>(this Try<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Try<IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Try<IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T>(this Try<Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Try<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Try<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Lst<U>> BindT<T, U>(this Try<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Try<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Lst<T>> FilterT<T>(this Try<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Try<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Try<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Try<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Lst<U>> MapT<T, U>(this Try<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Try<Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Try<Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T, K>(this Try<Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Try<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, K>(this Try<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Map<K, U>> BindT<T, K, U>(this Try<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, K>(this Try<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Map<K, T>> FilterT<T, K>(this Try<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, K, V>(this Try<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, K>(this Try<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, K>(this Try<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Map<K, U>> MapT<T, K, U>(this Try<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, K>(this Try<Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(this Try<Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T>(this Try<TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Try<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Try<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<TryOption<U>> BindT<T, U>(this Try<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Try<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<TryOption<T>> FilterT<T>(this Try<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Try<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Try<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Try<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<TryOption<U>> MapT<T, U>(this Try<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Try<TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Try<TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T>(this Try<Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Try<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Try<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Try<U>> BindT<T, U>(this Try<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Try<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Try<T>> FilterT<T>(this Try<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Try<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Try<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Try<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Try<U>> MapT<T, U>(this Try<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Try<Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Try<Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T, L>(this Try<Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Try<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this Try<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Either<L, U>> BindT<T, L, U>(this Try<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this Try<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Either<L, T>> FilterT<T, L>(this Try<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this Try<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this Try<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this Try<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Either<L, U>> MapT<T, L, U>(this Try<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this Try<Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this Try<Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T, L>(this Try<EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Try<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this Try<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<EitherUnsafe<L, U>> BindT<T, L, U>(this Try<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<EitherUnsafe<L, T>> FilterT<T, L>(this Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this Try<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this Try<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<EitherUnsafe<L, U>> MapT<T, L, U>(this Try<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this Try<EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this Try<EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static Reader<Env, T> ValueT<T, Env>(this Try<Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Try<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<T, Env>(this Try<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Reader<Env, U>> BindT<T, Env, U>(this Try<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<T, Env>(this Try<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Reader<Env, T>> FilterT<T, Env>(this Try<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<T, Env, V>(this Try<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<T, Env>(this Try<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<T, Env>(this Try<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Reader<Env, U>> MapT<T, Env, U>(this Try<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<T, Env>(this Try<Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(this Try<Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static Writer<Out, T> ValueT<T, Out>(this Try<Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Try<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<T, Out>(this Try<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Writer<Out, U>> BindT<T, Out, U>(this Try<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<T, Out>(this Try<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Writer<Out, T>> FilterT<T, Out>(this Try<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<T, Out, V>(this Try<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<T, Out>(this Try<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<T, Out>(this Try<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Writer<Out, U>> MapT<T, Out, U>(this Try<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<T, Out>(this Try<Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(this Try<Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static State<State, T> ValueT<T, State>(this Try<State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this Try<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<T, State>(this Try<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<State<State, U>> BindT<T, State, U>(this Try<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<T, State>(this Try<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<State<State, T>> FilterT<T, State>(this Try<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<T, State, V>(this Try<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<T, State>(this Try<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<T, State>(this Try<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<State<State, U>> MapT<T, State, U>(this Try<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<T, State>(this Try<State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(this Try<State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Try<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Rws<Env, Out, State, U>> BindT<T, Env, Out, State, U>(this Try<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Rws<Env, Out, State, T>> FilterT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<T, Env, Out, State, V>(this Try<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Rws<Env, Out, State, U>> MapT<T, Env, Out, State, U>(this Try<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        internal static T ValueT<T>(this Try<Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Try<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Try<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Try<Task<U>> BindT<T, U>(this Try<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Try<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Try<Task<T>> FilterT<T>(this Try<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Try<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Try<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Try<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Try<Task<U>> MapT<T, U>(this Try<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Try<Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Try<Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, IEnumerable<U>> BindT<L, T, U>(this Either<L, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, IEnumerable<T>> FilterT<L, T>(this Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, IEnumerable<U>> MapT<L, T, U>(this Either<L, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Lst<U>> BindT<L, T, U>(this Either<L, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Lst<T>> FilterT<L, T>(this Either<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Lst<U>> MapT<L, T, U>(this Either<L, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T, K>(this Either<L, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L, K>(this Either<L, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T, K>(this Either<L, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Map<K, U>> BindT<L, T, K, U>(this Either<L, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T, K>(this Either<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Map<K, T>> FilterT<L, T, K>(this Either<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, K, V>(this Either<L, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T, K>(this Either<L, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T, K>(this Either<L, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Map<K, U>> MapT<L, T, K, U>(this Either<L, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T, K>(this Either<L, Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T, K>(this Either<L, Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, TryOption<U>> BindT<L, T, U>(this Either<L, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, TryOption<T>> FilterT<L, T>(this Either<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, TryOption<U>> MapT<L, T, U>(this Either<L, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Try<U>> BindT<L, T, U>(this Either<L, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Try<T>> FilterT<L, T>(this Either<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Try<U>> MapT<L, T, U>(this Either<L, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Either<L, U>> BindT<L, T, U>(this Either<L, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Either<L, T>> FilterT<L, T>(this Either<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Either<L, U>> MapT<L, T, U>(this Either<L, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, EitherUnsafe<L, U>> BindT<L, T, U>(this Either<L, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, EitherUnsafe<L, T>> FilterT<L, T>(this Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, EitherUnsafe<L, U>> MapT<L, T, U>(this Either<L, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static Reader<Env, T> ValueT<L, T, Env>(this Either<L, Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<L, Env>(this Either<L, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<L, T, Env>(this Either<L, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Reader<Env, U>> BindT<L, T, Env, U>(this Either<L, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<L, T, Env>(this Either<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Reader<Env, T>> FilterT<L, T, Env>(this Either<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<L, T, Env, V>(this Either<L, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<L, T, Env>(this Either<L, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<L, T, Env>(this Either<L, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Reader<Env, U>> MapT<L, T, Env, U>(this Either<L, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<L, T, Env>(this Either<L, Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<L, T, Env>(this Either<L, Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static Writer<Out, T> ValueT<L, T, Out>(this Either<L, Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<L, Out>(this Either<L, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<L, T, Out>(this Either<L, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Writer<Out, U>> BindT<L, T, Out, U>(this Either<L, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<L, T, Out>(this Either<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Writer<Out, T>> FilterT<L, T, Out>(this Either<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<L, T, Out, V>(this Either<L, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<L, T, Out>(this Either<L, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<L, T, Out>(this Either<L, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Writer<Out, U>> MapT<L, T, Out, U>(this Either<L, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<L, T, Out>(this Either<L, Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<L, T, Out>(this Either<L, Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static State<State, T> ValueT<L, T, State>(this Either<L, State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<L, State>(this Either<L, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<L, T, State>(this Either<L, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, State<State, U>> BindT<L, T, State, U>(this Either<L, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<L, T, State>(this Either<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, State<State, T>> FilterT<L, T, State>(this Either<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<L, T, State, V>(this Either<L, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<L, T, State>(this Either<L, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<L, T, State>(this Either<L, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, State<State, U>> MapT<L, T, State, U>(this Either<L, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<L, T, State>(this Either<L, State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<L, T, State>(this Either<L, State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<L, Env, Out, State>(this Either<L, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Rws<Env, Out, State, U>> BindT<L, T, Env, Out, State, U>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Rws<Env, Out, State, T>> FilterT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<L, T, Env, Out, State, V>(this Either<L, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Rws<Env, Out, State, U>> MapT<L, T, Env, Out, State, U>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        internal static T ValueT<L, T>(this Either<L, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Either<L, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this Either<L, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Either<L, Task<U>> BindT<L, T, U>(this Either<L, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this Either<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Either<L, Task<T>> FilterT<L, T>(this Either<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this Either<L, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this Either<L, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this Either<L, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Either<L, Task<U>> MapT<L, T, U>(this Either<L, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this Either<L, Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this Either<L, Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, IEnumerable<U>> BindT<L, T, U>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, IEnumerable<T>> FilterT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, IEnumerable<U>> MapT<L, T, U>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Lst<U>> BindT<L, T, U>(this EitherUnsafe<L, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Lst<T>> FilterT<L, T>(this EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Lst<U>> MapT<L, T, U>(this EitherUnsafe<L, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L, K>(this EitherUnsafe<L, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Map<K, U>> BindT<L, T, K, U>(this EitherUnsafe<L, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Map<K, T>> FilterT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, K, V>(this EitherUnsafe<L, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Map<K, U>> MapT<L, T, K, U>(this EitherUnsafe<L, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T, K>(this EitherUnsafe<L, Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, TryOption<U>> BindT<L, T, U>(this EitherUnsafe<L, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, TryOption<T>> FilterT<L, T>(this EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, TryOption<U>> MapT<L, T, U>(this EitherUnsafe<L, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Try<U>> BindT<L, T, U>(this EitherUnsafe<L, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Try<T>> FilterT<L, T>(this EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Try<U>> MapT<L, T, U>(this EitherUnsafe<L, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Either<L, U>> BindT<L, T, U>(this EitherUnsafe<L, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Either<L, T>> FilterT<L, T>(this EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Either<L, U>> MapT<L, T, U>(this EitherUnsafe<L, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, EitherUnsafe<L, U>> BindT<L, T, U>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, EitherUnsafe<L, T>> FilterT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, EitherUnsafe<L, U>> MapT<L, T, U>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static Reader<Env, T> ValueT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<L, Env>(this EitherUnsafe<L, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Reader<Env, U>> BindT<L, T, Env, U>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Reader<Env, T>> FilterT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<L, T, Env, V>(this EitherUnsafe<L, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Reader<Env, U>> MapT<L, T, Env, U>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static Writer<Out, T> ValueT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<L, Out>(this EitherUnsafe<L, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Writer<Out, U>> BindT<L, T, Out, U>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Writer<Out, T>> FilterT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<L, T, Out, V>(this EitherUnsafe<L, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Writer<Out, U>> MapT<L, T, Out, U>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static State<State, T> ValueT<L, T, State>(this EitherUnsafe<L, State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<L, State>(this EitherUnsafe<L, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<L, T, State>(this EitherUnsafe<L, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, State<State, U>> BindT<L, T, State, U>(this EitherUnsafe<L, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<L, T, State>(this EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, State<State, T>> FilterT<L, T, State>(this EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<L, T, State, V>(this EitherUnsafe<L, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<L, T, State>(this EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<L, T, State>(this EitherUnsafe<L, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, State<State, U>> MapT<L, T, State, U>(this EitherUnsafe<L, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<L, T, State>(this EitherUnsafe<L, State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<L, T, State>(this EitherUnsafe<L, State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<L, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Rws<Env, Out, State, U>> BindT<L, T, Env, Out, State, U>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Rws<Env, Out, State, T>> FilterT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<L, T, Env, Out, State, V>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Rws<Env, Out, State, U>> MapT<L, T, Env, Out, State, U>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        internal static T ValueT<L, T>(this EitherUnsafe<L, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this EitherUnsafe<L, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<L, T>(this EitherUnsafe<L, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static EitherUnsafe<L, Task<U>> BindT<L, T, U>(this EitherUnsafe<L, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<L, T>(this EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static EitherUnsafe<L, Task<T>> FilterT<L, T>(this EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<L, T, V>(this EitherUnsafe<L, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<L, T>(this EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<L, T>(this EitherUnsafe<L, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static EitherUnsafe<L, Task<U>> MapT<L, T, U>(this EitherUnsafe<L, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<L, T>(this EitherUnsafe<L, Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<L, T>(this EitherUnsafe<L, Task<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T>(this Reader<Env, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Reader<Env, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T>(this Reader<Env, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, IEnumerable<U>> BindT<Env, T, U>(this Reader<Env, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T>(this Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, IEnumerable<T>> FilterT<Env, T>(this Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, V>(this Reader<Env, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T>(this Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T>(this Reader<Env, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, IEnumerable<U>> MapT<Env, T, U>(this Reader<Env, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T>(this Reader<Env, IEnumerable<T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(this Reader<Env, IEnumerable<T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T>(this Reader<Env, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Reader<Env, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T>(this Reader<Env, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Lst<U>> BindT<Env, T, U>(this Reader<Env, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T>(this Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Lst<T>> FilterT<Env, T>(this Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, V>(this Reader<Env, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T>(this Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T>(this Reader<Env, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Lst<U>> MapT<Env, T, U>(this Reader<Env, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T>(this Reader<Env, Lst<T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(this Reader<Env, Lst<T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T, K>(this Reader<Env, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env, K>(this Reader<Env, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T, K>(this Reader<Env, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Map<K, U>> BindT<Env, T, K, U>(this Reader<Env, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T, K>(this Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Map<K, T>> FilterT<Env, T, K>(this Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, K, V>(this Reader<Env, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T, K>(this Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T, K>(this Reader<Env, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Map<K, U>> MapT<Env, T, K, U>(this Reader<Env, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T, K>(this Reader<Env, Map<K, T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T, K>(this Reader<Env, Map<K, T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T>(this Reader<Env, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Reader<Env, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T>(this Reader<Env, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, TryOption<U>> BindT<Env, T, U>(this Reader<Env, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T>(this Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, TryOption<T>> FilterT<Env, T>(this Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, V>(this Reader<Env, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T>(this Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T>(this Reader<Env, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, TryOption<U>> MapT<Env, T, U>(this Reader<Env, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T>(this Reader<Env, TryOption<T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(this Reader<Env, TryOption<T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T>(this Reader<Env, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Reader<Env, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T>(this Reader<Env, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Try<U>> BindT<Env, T, U>(this Reader<Env, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T>(this Reader<Env, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Try<T>> FilterT<Env, T>(this Reader<Env, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, V>(this Reader<Env, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T>(this Reader<Env, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T>(this Reader<Env, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Try<U>> MapT<Env, T, U>(this Reader<Env, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T>(this Reader<Env, Try<T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(this Reader<Env, Try<T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T, L>(this Reader<Env, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env, L>(this Reader<Env, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T, L>(this Reader<Env, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Either<L, U>> BindT<Env, T, L, U>(this Reader<Env, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T, L>(this Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Either<L, T>> FilterT<Env, T, L>(this Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, L, V>(this Reader<Env, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T, L>(this Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T, L>(this Reader<Env, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Either<L, U>> MapT<Env, T, L, U>(this Reader<Env, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T, L>(this Reader<Env, Either<L, T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T, L>(this Reader<Env, Either<L, T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env, L>(this Reader<Env, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, EitherUnsafe<L, U>> BindT<Env, T, L, U>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, EitherUnsafe<L, T>> FilterT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, L, V>(this Reader<Env, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, EitherUnsafe<L, U>> MapT<Env, T, L, U>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, Reader<Env, T>> ValueT<Env, T>(this Reader<Env, Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, int>> SumT<Env>(this Reader<Env, Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, int>> CountT<Env, T>(this Reader<Env, Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, U>> BindT<Env, T, U>(this Reader<Env, Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, bool>> ExistsT<Env, T>(this Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, T>> FilterT<Env, T>(this Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, V>> FoldT<Env, T, V>(this Reader<Env, Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, bool>> ForAllT<Env, T>(this Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Reader<Env, Unit>> IterT<Env, T>(this Reader<Env, Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Reader<Env, U>> MapT<Env, T, U>(this Reader<Env, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<Env, T>(this Reader<Env, Reader<Env, T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<Env, T>(this Reader<Env, Reader<Env, T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        internal static Reader<Env, T> ValueT<Env, T>(this Reader<Env, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Reader<Env, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<Env, T>(this Reader<Env, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Reader<Env, Task<U>> BindT<Env, T, U>(this Reader<Env, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<Env, T>(this Reader<Env, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Reader<Env, Task<T>> FilterT<Env, T>(this Reader<Env, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<Env, T, V>(this Reader<Env, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<Env, T>(this Reader<Env, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<Env, T>(this Reader<Env, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Reader<Env, Task<U>> MapT<Env, T, U>(this Reader<Env, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, T>(this Reader<Env, Task<T>> self , Env liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, T>(this Reader<Env, Task<T>> self , Env liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T>(this Writer<Out, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Writer<Out, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T>(this Writer<Out, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, IEnumerable<U>> BindT<Out, T, U>(this Writer<Out, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T>(this Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, IEnumerable<T>> FilterT<Out, T>(this Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, V>(this Writer<Out, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T>(this Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T>(this Writer<Out, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, IEnumerable<U>> MapT<Out, T, U>(this Writer<Out, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T>(this Writer<Out, IEnumerable<T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(this Writer<Out, IEnumerable<T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T>(this Writer<Out, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Writer<Out, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T>(this Writer<Out, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Lst<U>> BindT<Out, T, U>(this Writer<Out, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T>(this Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Lst<T>> FilterT<Out, T>(this Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, V>(this Writer<Out, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T>(this Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T>(this Writer<Out, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Lst<U>> MapT<Out, T, U>(this Writer<Out, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T>(this Writer<Out, Lst<T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(this Writer<Out, Lst<T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T, K>(this Writer<Out, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out, K>(this Writer<Out, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T, K>(this Writer<Out, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Map<K, U>> BindT<Out, T, K, U>(this Writer<Out, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T, K>(this Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Map<K, T>> FilterT<Out, T, K>(this Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, K, V>(this Writer<Out, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T, K>(this Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T, K>(this Writer<Out, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Map<K, U>> MapT<Out, T, K, U>(this Writer<Out, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T, K>(this Writer<Out, Map<K, T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T, K>(this Writer<Out, Map<K, T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T>(this Writer<Out, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Writer<Out, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T>(this Writer<Out, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, TryOption<U>> BindT<Out, T, U>(this Writer<Out, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T>(this Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, TryOption<T>> FilterT<Out, T>(this Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, V>(this Writer<Out, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T>(this Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T>(this Writer<Out, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, TryOption<U>> MapT<Out, T, U>(this Writer<Out, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T>(this Writer<Out, TryOption<T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(this Writer<Out, TryOption<T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T>(this Writer<Out, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Writer<Out, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T>(this Writer<Out, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Try<U>> BindT<Out, T, U>(this Writer<Out, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T>(this Writer<Out, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Try<T>> FilterT<Out, T>(this Writer<Out, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, V>(this Writer<Out, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T>(this Writer<Out, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T>(this Writer<Out, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Try<U>> MapT<Out, T, U>(this Writer<Out, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T>(this Writer<Out, Try<T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(this Writer<Out, Try<T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T, L>(this Writer<Out, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out, L>(this Writer<Out, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T, L>(this Writer<Out, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Either<L, U>> BindT<Out, T, L, U>(this Writer<Out, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T, L>(this Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Either<L, T>> FilterT<Out, T, L>(this Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, L, V>(this Writer<Out, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T, L>(this Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T, L>(this Writer<Out, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Either<L, U>> MapT<Out, T, L, U>(this Writer<Out, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T, L>(this Writer<Out, Either<L, T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T, L>(this Writer<Out, Either<L, T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out, L>(this Writer<Out, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, EitherUnsafe<L, U>> BindT<Out, T, L, U>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, EitherUnsafe<L, T>> FilterT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, L, V>(this Writer<Out, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, EitherUnsafe<L, U>> MapT<Out, T, L, U>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, Writer<Out, T>> ValueT<Out, T>(this Writer<Out, Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, int>> SumT<Out>(this Writer<Out, Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, int>> CountT<Out, T>(this Writer<Out, Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, U>> BindT<Out, T, U>(this Writer<Out, Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, bool>> ExistsT<Out, T>(this Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, T>> FilterT<Out, T>(this Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, V>> FoldT<Out, T, V>(this Writer<Out, Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, bool>> ForAllT<Out, T>(this Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Writer<Out, Unit>> IterT<Out, T>(this Writer<Out, Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Writer<Out, U>> MapT<Out, T, U>(this Writer<Out, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<Out, T>(this Writer<Out, Writer<Out, T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<Out, T>(this Writer<Out, Writer<Out, T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        internal static Writer<Out, T> ValueT<Out, T>(this Writer<Out, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Writer<Out, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<Out, T>(this Writer<Out, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Writer<Out, Task<U>> BindT<Out, T, U>(this Writer<Out, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<Out, T>(this Writer<Out, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Writer<Out, Task<T>> FilterT<Out, T>(this Writer<Out, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<Out, T, V>(this Writer<Out, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<Out, T>(this Writer<Out, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<Out, T>(this Writer<Out, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Writer<Out, Task<U>> MapT<Out, T, U>(this Writer<Out, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Out, T>(this Writer<Out, Task<T>> self ) where T : struct => self.ValueT()().Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Out, T>(this Writer<Out, Task<T>> self ) where T : class => self.ValueT()().Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T>(this State<State, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this State<State, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T>(this State<State, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, IEnumerable<U>> BindT<State, T, U>(this State<State, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T>(this State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, IEnumerable<T>> FilterT<State, T>(this State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, V>(this State<State, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T>(this State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T>(this State<State, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, IEnumerable<U>> MapT<State, T, U>(this State<State, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T>(this State<State, IEnumerable<T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(this State<State, IEnumerable<T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T>(this State<State, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this State<State, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T>(this State<State, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Lst<U>> BindT<State, T, U>(this State<State, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T>(this State<State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Lst<T>> FilterT<State, T>(this State<State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, V>(this State<State, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T>(this State<State, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T>(this State<State, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Lst<U>> MapT<State, T, U>(this State<State, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T>(this State<State, Lst<T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(this State<State, Lst<T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T, K>(this State<State, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State, K>(this State<State, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T, K>(this State<State, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Map<K, U>> BindT<State, T, K, U>(this State<State, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T, K>(this State<State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Map<K, T>> FilterT<State, T, K>(this State<State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, K, V>(this State<State, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T, K>(this State<State, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T, K>(this State<State, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Map<K, U>> MapT<State, T, K, U>(this State<State, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T, K>(this State<State, Map<K, T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T, K>(this State<State, Map<K, T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T>(this State<State, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this State<State, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T>(this State<State, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, TryOption<U>> BindT<State, T, U>(this State<State, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T>(this State<State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, TryOption<T>> FilterT<State, T>(this State<State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, V>(this State<State, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T>(this State<State, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T>(this State<State, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, TryOption<U>> MapT<State, T, U>(this State<State, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T>(this State<State, TryOption<T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(this State<State, TryOption<T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T>(this State<State, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this State<State, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T>(this State<State, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Try<U>> BindT<State, T, U>(this State<State, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T>(this State<State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Try<T>> FilterT<State, T>(this State<State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, V>(this State<State, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T>(this State<State, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T>(this State<State, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Try<U>> MapT<State, T, U>(this State<State, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T>(this State<State, Try<T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(this State<State, Try<T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T, L>(this State<State, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State, L>(this State<State, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T, L>(this State<State, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Either<L, U>> BindT<State, T, L, U>(this State<State, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T, L>(this State<State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Either<L, T>> FilterT<State, T, L>(this State<State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, L, V>(this State<State, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T, L>(this State<State, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T, L>(this State<State, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Either<L, U>> MapT<State, T, L, U>(this State<State, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T, L>(this State<State, Either<L, T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T, L>(this State<State, Either<L, T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T, L>(this State<State, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State, L>(this State<State, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T, L>(this State<State, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, EitherUnsafe<L, U>> BindT<State, T, L, U>(this State<State, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T, L>(this State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, EitherUnsafe<L, T>> FilterT<State, T, L>(this State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, L, V>(this State<State, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T, L>(this State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T, L>(this State<State, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, EitherUnsafe<L, U>> MapT<State, T, L, U>(this State<State, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T, L>(this State<State, EitherUnsafe<L, T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T, L>(this State<State, EitherUnsafe<L, T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, State<State, T>> ValueT<State, T>(this State<State, State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, State<State, int>> SumT<State>(this State<State, State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, State<State, int>> CountT<State, T>(this State<State, State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, State<State, U>> BindT<State, T, U>(this State<State, State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, State<State, bool>> ExistsT<State, T>(this State<State, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, State<State, T>> FilterT<State, T>(this State<State, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, State<State, V>> FoldT<State, T, V>(this State<State, State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, State<State, bool>> ForAllT<State, T>(this State<State, State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, State<State, Unit>> IterT<State, T>(this State<State, State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, State<State, U>> MapT<State, T, U>(this State<State, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<State, T>(this State<State, State<State, T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<State, T>(this State<State, State<State, T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        internal static State<State, T> ValueT<State, T>(this State<State, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this State<State, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<State, T>(this State<State, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static State<State, Task<U>> BindT<State, T, U>(this State<State, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<State, T>(this State<State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static State<State, Task<T>> FilterT<State, T>(this State<State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<State, T, V>(this State<State, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<State, T>(this State<State, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<State, T>(this State<State, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static State<State, Task<U>> MapT<State, T, U>(this State<State, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<State, T>(this State<State, Task<T>> self , State liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<State, T>(this State<State, Task<T>> self , State liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Rws<Env, Out, State, IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, IEnumerable<U>> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, IEnumerable<T>> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, IEnumerable<U>> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Rws<Env, Out, State, Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Lst<U>> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Lst<T>> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Lst<U>> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State, K>(this Rws<Env, Out, State, Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Map<K, U>> BindT<Env, Out, State, T, K, U>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Map<K, T>> FilterT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, K, V>(this Rws<Env, Out, State, Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Map<K, U>> MapT<Env, Out, State, T, K, U>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Rws<Env, Out, State, TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, TryOption<U>> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, TryOption<T>> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, TryOption<U>> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Rws<Env, Out, State, Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Try<U>> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Try<T>> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Try<U>> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State, L>(this Rws<Env, Out, State, Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Either<L, U>> BindT<Env, Out, State, T, L, U>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Either<L, T>> FilterT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, L, V>(this Rws<Env, Out, State, Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Either<L, U>> MapT<Env, Out, State, T, L, U>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State, L>(this Rws<Env, Out, State, EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, EitherUnsafe<L, U>> BindT<Env, Out, State, T, L, U>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, EitherUnsafe<L, T>> FilterT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, L, V>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, EitherUnsafe<L, U>> MapT<Env, Out, State, T, L, U>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, Rws<Env, Out, State, T>> ValueT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, int>> SumT<Env, Out, State>(this Rws<Env, Out, State, Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, int>> CountT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, U>> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, bool>> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, T>> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, V>> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, bool>> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Rws<Env, Out, State, Unit>> IterT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Rws<Env, Out, State, U>> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Rws<Env, Out, State, Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Task<U>> BindT<Env, Out, State, T, U>(this Rws<Env, Out, State, Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Task<T>> FilterT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<Env, Out, State, T, V>(this Rws<Env, Out, State, Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Rws<Env, Out, State, Task<U>> MapT<Env, Out, State, T, U>(this Rws<Env, Out, State, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self , Tuple<Env,State> liftArg) where T : struct => self.ValueT()(liftArg).Value;
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self , Tuple<Env,State> liftArg) where T : class => self.ValueT()(liftArg).Value;
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T>(this Task<IEnumerable<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Task<IEnumerable<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Task<IEnumerable<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<IEnumerable<U>> BindT<T, U>(this Task<IEnumerable<T>> self, Func<T, IEnumerable<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Task<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<IEnumerable<T>> FilterT<T>(this Task<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Task<IEnumerable<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Task<IEnumerable<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Task<IEnumerable<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<IEnumerable<U>> MapT<T, U>(this Task<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Task<IEnumerable<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Task<IEnumerable<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T>(this Task<Lst<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Task<Lst<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Task<Lst<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Lst<U>> BindT<T, U>(this Task<Lst<T>> self, Func<T, Lst<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Task<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Lst<T>> FilterT<T>(this Task<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Task<Lst<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Task<Lst<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Task<Lst<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Lst<U>> MapT<T, U>(this Task<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Task<Lst<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Task<Lst<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T, K>(this Task<Map<K, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<K>(this Task<Map<K, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, K>(this Task<Map<K, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Map<K, U>> BindT<T, K, U>(this Task<Map<K, T>> self, Func<T, Map<K, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, K>(this Task<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Map<K, T>> FilterT<T, K>(this Task<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, K, V>(this Task<Map<K, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, K>(this Task<Map<K, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, K>(this Task<Map<K, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Map<K, U>> MapT<T, K, U>(this Task<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, K>(this Task<Map<K, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, K>(this Task<Map<K, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T>(this Task<TryOption<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Task<TryOption<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Task<TryOption<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<TryOption<U>> BindT<T, U>(this Task<TryOption<T>> self, Func<T, TryOption<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Task<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<TryOption<T>> FilterT<T>(this Task<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Task<TryOption<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Task<TryOption<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Task<TryOption<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<TryOption<U>> MapT<T, U>(this Task<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Task<TryOption<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Task<TryOption<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T>(this Task<Try<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Task<Try<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Task<Try<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Try<U>> BindT<T, U>(this Task<Try<T>> self, Func<T, Try<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Task<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Try<T>> FilterT<T>(this Task<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Task<Try<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Task<Try<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Task<Try<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Try<U>> MapT<T, U>(this Task<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Task<Try<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Task<Try<T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T, L>(this Task<Either<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Task<Either<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this Task<Either<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Either<L, U>> BindT<T, L, U>(this Task<Either<L, T>> self, Func<T, Either<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this Task<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Either<L, T>> FilterT<T, L>(this Task<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this Task<Either<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this Task<Either<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this Task<Either<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Either<L, U>> MapT<T, L, U>(this Task<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this Task<Either<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this Task<Either<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T, L>(this Task<EitherUnsafe<L, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT<L>(this Task<EitherUnsafe<L, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T, L>(this Task<EitherUnsafe<L, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<EitherUnsafe<L, U>> BindT<T, L, U>(this Task<EitherUnsafe<L, T>> self, Func<T, EitherUnsafe<L, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T, L>(this Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<EitherUnsafe<L, T>> FilterT<T, L>(this Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, L, V>(this Task<EitherUnsafe<L, T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T, L>(this Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T, L>(this Task<EitherUnsafe<L, T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<EitherUnsafe<L, U>> MapT<T, L, U>(this Task<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T, L>(this Task<EitherUnsafe<L, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T, L>(this Task<EitherUnsafe<L, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static Reader<Env, T> ValueT<T, Env>(this Task<Reader<Env, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Reader<Env, int> SumT<Env>(this Task<Reader<Env, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Reader<Env, int> CountT<T, Env>(this Task<Reader<Env, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Reader<Env, U>> BindT<T, Env, U>(this Task<Reader<Env, T>> self, Func<T, Reader<Env, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Reader<Env, bool> ExistsT<T, Env>(this Task<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Reader<Env, T>> FilterT<T, Env>(this Task<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Reader<Env, V> FoldT<T, Env, V>(this Task<Reader<Env, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Reader<Env, bool> ForAllT<T, Env>(this Task<Reader<Env, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Reader<Env, Unit> IterT<T, Env>(this Task<Reader<Env, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Reader<Env, U>> MapT<T, Env, U>(this Task<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Reader<Env, T> LiftT<T, Env>(this Task<Reader<Env, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Reader<Env, T> LiftUnsafeT<T, Env>(this Task<Reader<Env, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static Writer<Out, T> ValueT<T, Out>(this Task<Writer<Out, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Writer<Out, int> SumT<Out>(this Task<Writer<Out, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Writer<Out, int> CountT<T, Out>(this Task<Writer<Out, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Writer<Out, U>> BindT<T, Out, U>(this Task<Writer<Out, T>> self, Func<T, Writer<Out, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Writer<Out, bool> ExistsT<T, Out>(this Task<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Writer<Out, T>> FilterT<T, Out>(this Task<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Writer<Out, V> FoldT<T, Out, V>(this Task<Writer<Out, T>> self, V state, Func<V, T, V> fold) => ()=> self.FoldT(state,(s,x) => x.FoldT(s, fold)().Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Writer<Out, bool> ForAllT<T, Out>(this Task<Writer<Out, T>> self, Func<T, bool> pred) => ()=> self.ForAllT(pred)();
        /// <summary>
        /// Iter
        /// </summary>
        public static Writer<Out, Unit> IterT<T, Out>(this Task<Writer<Out, T>> self, Action<T> action) => ()=> self.IterT(x => x.IterT(action)());
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Writer<Out, U>> MapT<T, Out, U>(this Task<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Writer<Out, T> LiftT<T, Out>(this Task<Writer<Out, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Writer<Out, T> LiftUnsafeT<T, Out>(this Task<Writer<Out, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static State<State, T> ValueT<T, State>(this Task<State<State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static State<State, int> SumT<State>(this Task<State<State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static State<State, int> CountT<T, State>(this Task<State<State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<State<State, U>> BindT<T, State, U>(this Task<State<State, T>> self, Func<T, State<State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static State<State, bool> ExistsT<T, State>(this Task<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<State<State, T>> FilterT<T, State>(this Task<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static State<State, V> FoldT<T, State, V>(this Task<State<State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static State<State, bool> ForAllT<T, State>(this Task<State<State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static State<State, Unit> IterT<T, State>(this Task<State<State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<State<State, U>> MapT<T, State, U>(this Task<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static State<State, T> LiftT<T, State>(this Task<State<State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static State<State, T> LiftUnsafeT<T, State>(this Task<State<State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static Rws<Env, Out, State, T> ValueT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> SumT<Env, Out, State>(this Task<Rws<Env, Out, State, int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static Rws<Env, Out, State, int> CountT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Rws<Env, Out, State, U>> BindT<T, Env, Out, State, U>(this Task<Rws<Env, Out, State, T>> self, Func<T, Rws<Env, Out, State, U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ExistsT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Rws<Env, Out, State, T>> FilterT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static Rws<Env, Out, State, V> FoldT<T, Env, Out, State, V>(this Task<Rws<Env, Out, State, T>> self, V state, Func<V, T, V> fold) => args => self.FoldT(state,(s,x) => x.FoldT(s, fold)(args).Value);
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static Rws<Env, Out, State, bool> ForAllT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => args => self.ForAllT(pred)(args);
        /// <summary>
        /// Iter
        /// </summary>
        public static Rws<Env, Out, State, Unit> IterT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self, Action<T> action) => args => self.IterT(x => x.IterT(action)(args));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Rws<Env, Out, State, U>> MapT<T, Env, Out, State, U>(this Task<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static Rws<Env, Out, State, T> LiftUnsafeT<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self ) where T : class => self.ValueT();
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        internal static T ValueT<T>(this Task<Task<T>> self) => self.MapT(x=> x.InnerValue()).InnerValue();
        /// <summary>
        /// Sum
        /// </summary>
        [Pure] public static int SumT(this Task<Task<int>> self) => self.MapT(x => x.SumT()).SumT();
        /// <summary>
        /// Count
        /// </summary>
        [Pure] public static int CountT<T>(this Task<Task<T>> self) => self.MapT(x => x.CountT()).SumT();
        /// <summary>
        /// Bind
        /// </summary>
        [Pure] public static Task<Task<U>> BindT<T, U>(this Task<Task<T>> self, Func<T, Task<U>> binder) => self.MapT(x => x.BindT(binder));
        /// <summary>
        /// Exists
        /// </summary>
        [Pure] public static bool ExistsT<T>(this Task<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.ExistsT(pred)).ExistsT(x=>x);
        /// <summary>
        /// Filter
        /// </summary>
        [Pure] public static Task<Task<T>> FilterT<T>(this Task<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// Fold
        /// </summary>
        [Pure] public static V FoldT<T, V>(this Task<Task<T>> self, V state, Func<V, T, V> fold) => self.FoldT(state,(s,x) => x.FoldT(s, fold));
        /// <summary>
        /// ForAll
        /// </summary>
        [Pure] public static bool ForAllT<T>(this Task<Task<T>> self, Func<T, bool> pred) => self.ForAllT(pred);
        /// <summary>
        /// Iter
        /// </summary>
        public static Unit IterT<T>(this Task<Task<T>> self, Action<T> action) => self.IterT(x => x.IterT(action));
        /// <summary>
        /// Map
        /// </summary>
        [Pure] public static Task<Task<U>> MapT<T, U>(this Task<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Lift
        /// </summary>
        [Pure] public static T LiftT<T>(this Task<Task<T>> self ) where T : struct => self.ValueT();
        /// <summary>
        /// LiftUnsafe
        /// </summary>
        [Pure] public static T LiftUnsafeT<T>(this Task<Task<T>> self ) where T : class => self.ValueT();
    }

    namespace Linq
    {
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static IEnumerable<U> Select<T, U>(this IEnumerable<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static IEnumerable<T> Where<T>(this IEnumerable<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static IEnumerable<V> SelectMany<T, U, V>(this IEnumerable<T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Lst<U> Select<T, U>(this Lst<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Lst<T> Where<T>(this Lst<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Lst<V> SelectMany<T, U, V>(this Lst<T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Map<K, U> Select<K, T, U>(this Map<K, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Map<K, T> Where<K, T>(this Map<K, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Map<K, V> SelectMany<K, T, U, V>(this Map<K, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static TryOption<U> Select<T, U>(this TryOption<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static TryOption<T> Where<T>(this TryOption<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static TryOption<V> SelectMany<T, U, V>(this TryOption<T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Try<U> Select<T, U>(this Try<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Try<T> Where<T>(this Try<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Try<V> SelectMany<T, U, V>(this Try<T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Either<L, U> Select<L, T, U>(this Either<L, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Either<L, T> Where<L, T>(this Either<L, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Either<L, V> SelectMany<L, T, U, V>(this Either<L, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static EitherUnsafe<L, U> Select<L, T, U>(this EitherUnsafe<L, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static EitherUnsafe<L, T> Where<L, T>(this EitherUnsafe<L, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static EitherUnsafe<L, V> SelectMany<L, T, U, V>(this EitherUnsafe<L, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Reader<Env, U> Select<Env, T, U>(this Reader<Env, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Reader<Env, T> Where<Env, T>(this Reader<Env, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Reader<Env, V> SelectMany<Env, T, U, V>(this Reader<Env, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Writer<Out, U> Select<Out, T, U>(this Writer<Out, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Writer<Out, T> Where<Out, T>(this Writer<Out, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Writer<Out, V> SelectMany<Out, T, U, V>(this Writer<Out, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static State<State, U> Select<State, T, U>(this State<State, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static State<State, T> Where<State, T>(this State<State, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static State<State, V> SelectMany<State, T, U, V>(this State<State, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Rws<Env, Out, State, U> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Rws<Env, Out, State, T> Where<Env, Out, State, T>(this Rws<Env, Out, State, T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Rws<Env, Out, State, V> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskMonad {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Task<U> Select<T, U>(this Task<T> self, Func<T, U> mapper) => self.Map(mapper);
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Task<T> Where<T>(this Task<T> self, Func<T, bool> pred) => self.Filter(pred);
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] internal static Task<V> SelectMany<T, U, V>(this Task<T> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(t => project(t, bind(t)));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<IEnumerable<U>> Select<T, U>(this IEnumerable<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<IEnumerable<T>> Where<T>(this IEnumerable<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<IEnumerable<V>> SelectMany<T, U, V>(this IEnumerable<IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Lst<U>> Select<T, U>(this IEnumerable<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Lst<T>> Where<T>(this IEnumerable<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Lst<V>> SelectMany<T, U, V>(this IEnumerable<Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Map<K, U>> Select<T, K, U>(this IEnumerable<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Map<K, T>> Where<T, K>(this IEnumerable<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Map<K, V>> SelectMany<T, K, U, V>(this IEnumerable<Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<TryOption<U>> Select<T, U>(this IEnumerable<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<TryOption<T>> Where<T>(this IEnumerable<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<TryOption<V>> SelectMany<T, U, V>(this IEnumerable<TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Try<U>> Select<T, U>(this IEnumerable<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Try<T>> Where<T>(this IEnumerable<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Try<V>> SelectMany<T, U, V>(this IEnumerable<Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Either<L, U>> Select<T, L, U>(this IEnumerable<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Either<L, T>> Where<T, L>(this IEnumerable<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Either<L, V>> SelectMany<T, L, U, V>(this IEnumerable<Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<EitherUnsafe<L, U>> Select<T, L, U>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<EitherUnsafe<L, T>> Where<T, L>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this IEnumerable<EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Reader<Env, U>> Select<T, Env, U>(this IEnumerable<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Reader<Env, T>> Where<T, Env>(this IEnumerable<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Reader<Env, V>> SelectMany<T, Env, U, V>(this IEnumerable<Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Writer<Out, U>> Select<T, Out, U>(this IEnumerable<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Writer<Out, T>> Where<T, Out>(this IEnumerable<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Writer<Out, V>> SelectMany<T, Out, U, V>(this IEnumerable<Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<State<State, U>> Select<T, State, U>(this IEnumerable<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<State<State, T>> Where<T, State>(this IEnumerable<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<State<State, V>> SelectMany<T, State, U, V>(this IEnumerable<State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Rws<Env, Out, State, U>> Select<T, Env, Out, State, U>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Rws<Env, Out, State, T>> Where<T, Env, Out, State>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this IEnumerable<Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Task<U>> Select<T, U>(this IEnumerable<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Task<T>> Where<T>(this IEnumerable<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static IEnumerable<Task<V>> SelectMany<T, U, V>(this IEnumerable<Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<IEnumerable<U>> Select<T, U>(this Lst<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<IEnumerable<T>> Where<T>(this Lst<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<IEnumerable<V>> SelectMany<T, U, V>(this Lst<IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Lst<U>> Select<T, U>(this Lst<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Lst<T>> Where<T>(this Lst<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Lst<V>> SelectMany<T, U, V>(this Lst<Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Map<K, U>> Select<T, K, U>(this Lst<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Map<K, T>> Where<T, K>(this Lst<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Map<K, V>> SelectMany<T, K, U, V>(this Lst<Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<TryOption<U>> Select<T, U>(this Lst<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<TryOption<T>> Where<T>(this Lst<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<TryOption<V>> SelectMany<T, U, V>(this Lst<TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Try<U>> Select<T, U>(this Lst<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Try<T>> Where<T>(this Lst<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Try<V>> SelectMany<T, U, V>(this Lst<Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Either<L, U>> Select<T, L, U>(this Lst<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Either<L, T>> Where<T, L>(this Lst<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Either<L, V>> SelectMany<T, L, U, V>(this Lst<Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<EitherUnsafe<L, U>> Select<T, L, U>(this Lst<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<EitherUnsafe<L, T>> Where<T, L>(this Lst<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this Lst<EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Reader<Env, U>> Select<T, Env, U>(this Lst<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Reader<Env, T>> Where<T, Env>(this Lst<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Reader<Env, V>> SelectMany<T, Env, U, V>(this Lst<Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Writer<Out, U>> Select<T, Out, U>(this Lst<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Writer<Out, T>> Where<T, Out>(this Lst<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Writer<Out, V>> SelectMany<T, Out, U, V>(this Lst<Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<State<State, U>> Select<T, State, U>(this Lst<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<State<State, T>> Where<T, State>(this Lst<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<State<State, V>> SelectMany<T, State, U, V>(this Lst<State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Rws<Env, Out, State, U>> Select<T, Env, Out, State, U>(this Lst<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Rws<Env, Out, State, T>> Where<T, Env, Out, State>(this Lst<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this Lst<Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ListTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Task<U>> Select<T, U>(this Lst<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Task<T>> Where<T>(this Lst<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Lst<Task<V>> SelectMany<T, U, V>(this Lst<Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, IEnumerable<U>> Select<K, T, U>(this Map<K, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, IEnumerable<T>> Where<K, T>(this Map<K, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, IEnumerable<V>> SelectMany<K, T, U, V>(this Map<K, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Lst<U>> Select<K, T, U>(this Map<K, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Lst<T>> Where<K, T>(this Map<K, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Lst<V>> SelectMany<K, T, U, V>(this Map<K, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Map<K, U>> Select<K, T, U>(this Map<K, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Map<K, T>> Where<K, T>(this Map<K, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Map<K, V>> SelectMany<K, T, U, V>(this Map<K, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, TryOption<U>> Select<K, T, U>(this Map<K, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, TryOption<T>> Where<K, T>(this Map<K, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, TryOption<V>> SelectMany<K, T, U, V>(this Map<K, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Try<U>> Select<K, T, U>(this Map<K, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Try<T>> Where<K, T>(this Map<K, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Try<V>> SelectMany<K, T, U, V>(this Map<K, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Either<L, U>> Select<K, T, L, U>(this Map<K, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Either<L, T>> Where<K, T, L>(this Map<K, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Either<L, V>> SelectMany<K, T, L, U, V>(this Map<K, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, EitherUnsafe<L, U>> Select<K, T, L, U>(this Map<K, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, EitherUnsafe<L, T>> Where<K, T, L>(this Map<K, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, EitherUnsafe<L, V>> SelectMany<K, T, L, U, V>(this Map<K, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Reader<Env, U>> Select<K, T, Env, U>(this Map<K, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Reader<Env, T>> Where<K, T, Env>(this Map<K, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Reader<Env, V>> SelectMany<K, T, Env, U, V>(this Map<K, Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Writer<Out, U>> Select<K, T, Out, U>(this Map<K, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Writer<Out, T>> Where<K, T, Out>(this Map<K, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Writer<Out, V>> SelectMany<K, T, Out, U, V>(this Map<K, Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, State<State, U>> Select<K, T, State, U>(this Map<K, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, State<State, T>> Where<K, T, State>(this Map<K, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, State<State, V>> SelectMany<K, T, State, U, V>(this Map<K, State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Rws<Env, Out, State, U>> Select<K, T, Env, Out, State, U>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Rws<Env, Out, State, T>> Where<K, T, Env, Out, State>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Rws<Env, Out, State, V>> SelectMany<K, T, Env, Out, State, U, V>(this Map<K, Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class MapTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Task<U>> Select<K, T, U>(this Map<K, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Task<T>> Where<K, T>(this Map<K, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Map<K, Task<V>> SelectMany<K, T, U, V>(this Map<K, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<IEnumerable<U>> Select<T, U>(this TryOption<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<IEnumerable<T>> Where<T>(this TryOption<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<IEnumerable<V>> SelectMany<T, U, V>(this TryOption<IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Lst<U>> Select<T, U>(this TryOption<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Lst<T>> Where<T>(this TryOption<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Lst<V>> SelectMany<T, U, V>(this TryOption<Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Map<K, U>> Select<T, K, U>(this TryOption<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Map<K, T>> Where<T, K>(this TryOption<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Map<K, V>> SelectMany<T, K, U, V>(this TryOption<Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<TryOption<U>> Select<T, U>(this TryOption<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<TryOption<T>> Where<T>(this TryOption<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<TryOption<V>> SelectMany<T, U, V>(this TryOption<TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Try<U>> Select<T, U>(this TryOption<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Try<T>> Where<T>(this TryOption<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Try<V>> SelectMany<T, U, V>(this TryOption<Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Either<L, U>> Select<T, L, U>(this TryOption<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Either<L, T>> Where<T, L>(this TryOption<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Either<L, V>> SelectMany<T, L, U, V>(this TryOption<Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<EitherUnsafe<L, U>> Select<T, L, U>(this TryOption<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<EitherUnsafe<L, T>> Where<T, L>(this TryOption<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this TryOption<EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Reader<Env, U>> Select<T, Env, U>(this TryOption<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Reader<Env, T>> Where<T, Env>(this TryOption<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Reader<Env, V>> SelectMany<T, Env, U, V>(this TryOption<Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Writer<Out, U>> Select<T, Out, U>(this TryOption<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Writer<Out, T>> Where<T, Out>(this TryOption<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Writer<Out, V>> SelectMany<T, Out, U, V>(this TryOption<Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<State<State, U>> Select<T, State, U>(this TryOption<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<State<State, T>> Where<T, State>(this TryOption<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<State<State, V>> SelectMany<T, State, U, V>(this TryOption<State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Rws<Env, Out, State, U>> Select<T, Env, Out, State, U>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Rws<Env, Out, State, T>> Where<T, Env, Out, State>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this TryOption<Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryOptionTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Task<U>> Select<T, U>(this TryOption<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Task<T>> Where<T>(this TryOption<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static TryOption<Task<V>> SelectMany<T, U, V>(this TryOption<Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<IEnumerable<U>> Select<T, U>(this Try<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<IEnumerable<T>> Where<T>(this Try<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<IEnumerable<V>> SelectMany<T, U, V>(this Try<IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Lst<U>> Select<T, U>(this Try<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Lst<T>> Where<T>(this Try<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Lst<V>> SelectMany<T, U, V>(this Try<Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Map<K, U>> Select<T, K, U>(this Try<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Map<K, T>> Where<T, K>(this Try<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Map<K, V>> SelectMany<T, K, U, V>(this Try<Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<TryOption<U>> Select<T, U>(this Try<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<TryOption<T>> Where<T>(this Try<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<TryOption<V>> SelectMany<T, U, V>(this Try<TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Try<U>> Select<T, U>(this Try<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Try<T>> Where<T>(this Try<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Try<V>> SelectMany<T, U, V>(this Try<Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Either<L, U>> Select<T, L, U>(this Try<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Either<L, T>> Where<T, L>(this Try<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Either<L, V>> SelectMany<T, L, U, V>(this Try<Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<EitherUnsafe<L, U>> Select<T, L, U>(this Try<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<EitherUnsafe<L, T>> Where<T, L>(this Try<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this Try<EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Reader<Env, U>> Select<T, Env, U>(this Try<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Reader<Env, T>> Where<T, Env>(this Try<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Reader<Env, V>> SelectMany<T, Env, U, V>(this Try<Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Writer<Out, U>> Select<T, Out, U>(this Try<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Writer<Out, T>> Where<T, Out>(this Try<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Writer<Out, V>> SelectMany<T, Out, U, V>(this Try<Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<State<State, U>> Select<T, State, U>(this Try<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<State<State, T>> Where<T, State>(this Try<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<State<State, V>> SelectMany<T, State, U, V>(this Try<State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Rws<Env, Out, State, U>> Select<T, Env, Out, State, U>(this Try<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Rws<Env, Out, State, T>> Where<T, Env, Out, State>(this Try<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this Try<Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TryTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Task<U>> Select<T, U>(this Try<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Task<T>> Where<T>(this Try<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Try<Task<V>> SelectMany<T, U, V>(this Try<Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, IEnumerable<U>> Select<L, T, U>(this Either<L, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, IEnumerable<T>> Where<L, T>(this Either<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, IEnumerable<V>> SelectMany<L, T, U, V>(this Either<L, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Lst<U>> Select<L, T, U>(this Either<L, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Lst<T>> Where<L, T>(this Either<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Lst<V>> SelectMany<L, T, U, V>(this Either<L, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Map<K, U>> Select<L, T, K, U>(this Either<L, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Map<K, T>> Where<L, T, K>(this Either<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Map<K, V>> SelectMany<L, T, K, U, V>(this Either<L, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, TryOption<U>> Select<L, T, U>(this Either<L, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, TryOption<T>> Where<L, T>(this Either<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, TryOption<V>> SelectMany<L, T, U, V>(this Either<L, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Try<U>> Select<L, T, U>(this Either<L, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Try<T>> Where<L, T>(this Either<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Try<V>> SelectMany<L, T, U, V>(this Either<L, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Either<L, U>> Select<L, T, U>(this Either<L, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Either<L, T>> Where<L, T>(this Either<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Either<L, V>> SelectMany<L, T, U, V>(this Either<L, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, EitherUnsafe<L, U>> Select<L, T, U>(this Either<L, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, EitherUnsafe<L, T>> Where<L, T>(this Either<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, EitherUnsafe<L, V>> SelectMany<L, T, U, V>(this Either<L, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Reader<Env, U>> Select<L, T, Env, U>(this Either<L, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Reader<Env, T>> Where<L, T, Env>(this Either<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Reader<Env, V>> SelectMany<L, T, Env, U, V>(this Either<L, Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Writer<Out, U>> Select<L, T, Out, U>(this Either<L, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Writer<Out, T>> Where<L, T, Out>(this Either<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Writer<Out, V>> SelectMany<L, T, Out, U, V>(this Either<L, Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, State<State, U>> Select<L, T, State, U>(this Either<L, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, State<State, T>> Where<L, T, State>(this Either<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, State<State, V>> SelectMany<L, T, State, U, V>(this Either<L, State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Rws<Env, Out, State, U>> Select<L, T, Env, Out, State, U>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Rws<Env, Out, State, T>> Where<L, T, Env, Out, State>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Rws<Env, Out, State, V>> SelectMany<L, T, Env, Out, State, U, V>(this Either<L, Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Task<U>> Select<L, T, U>(this Either<L, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Task<T>> Where<L, T>(this Either<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Either<L, Task<V>> SelectMany<L, T, U, V>(this Either<L, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, IEnumerable<U>> Select<L, T, U>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, IEnumerable<T>> Where<L, T>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, IEnumerable<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Lst<U>> Select<L, T, U>(this EitherUnsafe<L, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Lst<T>> Where<L, T>(this EitherUnsafe<L, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Lst<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Map<K, U>> Select<L, T, K, U>(this EitherUnsafe<L, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Map<K, T>> Where<L, T, K>(this EitherUnsafe<L, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Map<K, V>> SelectMany<L, T, K, U, V>(this EitherUnsafe<L, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, TryOption<U>> Select<L, T, U>(this EitherUnsafe<L, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, TryOption<T>> Where<L, T>(this EitherUnsafe<L, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, TryOption<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Try<U>> Select<L, T, U>(this EitherUnsafe<L, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Try<T>> Where<L, T>(this EitherUnsafe<L, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Try<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Either<L, U>> Select<L, T, U>(this EitherUnsafe<L, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Either<L, T>> Where<L, T>(this EitherUnsafe<L, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Either<L, V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, EitherUnsafe<L, U>> Select<L, T, U>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, EitherUnsafe<L, T>> Where<L, T>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, EitherUnsafe<L, V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Reader<Env, U>> Select<L, T, Env, U>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Reader<Env, T>> Where<L, T, Env>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Reader<Env, V>> SelectMany<L, T, Env, U, V>(this EitherUnsafe<L, Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Writer<Out, U>> Select<L, T, Out, U>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Writer<Out, T>> Where<L, T, Out>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Writer<Out, V>> SelectMany<L, T, Out, U, V>(this EitherUnsafe<L, Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, State<State, U>> Select<L, T, State, U>(this EitherUnsafe<L, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, State<State, T>> Where<L, T, State>(this EitherUnsafe<L, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, State<State, V>> SelectMany<L, T, State, U, V>(this EitherUnsafe<L, State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Rws<Env, Out, State, U>> Select<L, T, Env, Out, State, U>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Rws<Env, Out, State, T>> Where<L, T, Env, Out, State>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Rws<Env, Out, State, V>> SelectMany<L, T, Env, Out, State, U, V>(this EitherUnsafe<L, Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class EitherUnsafeTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Task<U>> Select<L, T, U>(this EitherUnsafe<L, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Task<T>> Where<L, T>(this EitherUnsafe<L, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static EitherUnsafe<L, Task<V>> SelectMany<L, T, U, V>(this EitherUnsafe<L, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, IEnumerable<U>> Select<Env, T, U>(this Reader<Env, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, IEnumerable<T>> Where<Env, T>(this Reader<Env, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, IEnumerable<V>> SelectMany<Env, T, U, V>(this Reader<Env, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Lst<U>> Select<Env, T, U>(this Reader<Env, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Lst<T>> Where<Env, T>(this Reader<Env, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Lst<V>> SelectMany<Env, T, U, V>(this Reader<Env, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Map<K, U>> Select<Env, T, K, U>(this Reader<Env, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Map<K, T>> Where<Env, T, K>(this Reader<Env, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Map<K, V>> SelectMany<Env, T, K, U, V>(this Reader<Env, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, TryOption<U>> Select<Env, T, U>(this Reader<Env, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, TryOption<T>> Where<Env, T>(this Reader<Env, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, TryOption<V>> SelectMany<Env, T, U, V>(this Reader<Env, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Try<U>> Select<Env, T, U>(this Reader<Env, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Try<T>> Where<Env, T>(this Reader<Env, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Try<V>> SelectMany<Env, T, U, V>(this Reader<Env, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Either<L, U>> Select<Env, T, L, U>(this Reader<Env, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Either<L, T>> Where<Env, T, L>(this Reader<Env, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Either<L, V>> SelectMany<Env, T, L, U, V>(this Reader<Env, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, EitherUnsafe<L, U>> Select<Env, T, L, U>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, EitherUnsafe<L, T>> Where<Env, T, L>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, EitherUnsafe<L, V>> SelectMany<Env, T, L, U, V>(this Reader<Env, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Reader<Env, U>> Select<Env, T, U>(this Reader<Env, Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Reader<Env, T>> Where<Env, T>(this Reader<Env, Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Reader<Env, V>> SelectMany<Env, T, U, V>(this Reader<Env, Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class ReaderTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Task<U>> Select<Env, T, U>(this Reader<Env, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Task<T>> Where<Env, T>(this Reader<Env, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Reader<Env, Task<V>> SelectMany<Env, T, U, V>(this Reader<Env, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, IEnumerable<U>> Select<Out, T, U>(this Writer<Out, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, IEnumerable<T>> Where<Out, T>(this Writer<Out, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, IEnumerable<V>> SelectMany<Out, T, U, V>(this Writer<Out, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Lst<U>> Select<Out, T, U>(this Writer<Out, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Lst<T>> Where<Out, T>(this Writer<Out, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Lst<V>> SelectMany<Out, T, U, V>(this Writer<Out, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Map<K, U>> Select<Out, T, K, U>(this Writer<Out, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Map<K, T>> Where<Out, T, K>(this Writer<Out, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Map<K, V>> SelectMany<Out, T, K, U, V>(this Writer<Out, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, TryOption<U>> Select<Out, T, U>(this Writer<Out, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, TryOption<T>> Where<Out, T>(this Writer<Out, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, TryOption<V>> SelectMany<Out, T, U, V>(this Writer<Out, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Try<U>> Select<Out, T, U>(this Writer<Out, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Try<T>> Where<Out, T>(this Writer<Out, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Try<V>> SelectMany<Out, T, U, V>(this Writer<Out, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Either<L, U>> Select<Out, T, L, U>(this Writer<Out, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Either<L, T>> Where<Out, T, L>(this Writer<Out, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Either<L, V>> SelectMany<Out, T, L, U, V>(this Writer<Out, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, EitherUnsafe<L, U>> Select<Out, T, L, U>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, EitherUnsafe<L, T>> Where<Out, T, L>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, EitherUnsafe<L, V>> SelectMany<Out, T, L, U, V>(this Writer<Out, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Writer<Out, U>> Select<Out, T, U>(this Writer<Out, Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Writer<Out, T>> Where<Out, T>(this Writer<Out, Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Writer<Out, V>> SelectMany<Out, T, U, V>(this Writer<Out, Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class WriterTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Task<U>> Select<Out, T, U>(this Writer<Out, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Task<T>> Where<Out, T>(this Writer<Out, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Writer<Out, Task<V>> SelectMany<Out, T, U, V>(this Writer<Out, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, IEnumerable<U>> Select<State, T, U>(this State<State, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, IEnumerable<T>> Where<State, T>(this State<State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, IEnumerable<V>> SelectMany<State, T, U, V>(this State<State, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Lst<U>> Select<State, T, U>(this State<State, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Lst<T>> Where<State, T>(this State<State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Lst<V>> SelectMany<State, T, U, V>(this State<State, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Map<K, U>> Select<State, T, K, U>(this State<State, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Map<K, T>> Where<State, T, K>(this State<State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Map<K, V>> SelectMany<State, T, K, U, V>(this State<State, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, TryOption<U>> Select<State, T, U>(this State<State, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, TryOption<T>> Where<State, T>(this State<State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, TryOption<V>> SelectMany<State, T, U, V>(this State<State, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Try<U>> Select<State, T, U>(this State<State, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Try<T>> Where<State, T>(this State<State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Try<V>> SelectMany<State, T, U, V>(this State<State, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Either<L, U>> Select<State, T, L, U>(this State<State, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Either<L, T>> Where<State, T, L>(this State<State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Either<L, V>> SelectMany<State, T, L, U, V>(this State<State, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, EitherUnsafe<L, U>> Select<State, T, L, U>(this State<State, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, EitherUnsafe<L, T>> Where<State, T, L>(this State<State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, EitherUnsafe<L, V>> SelectMany<State, T, L, U, V>(this State<State, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, State<State, U>> Select<State, T, U>(this State<State, State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, State<State, T>> Where<State, T>(this State<State, State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, State<State, V>> SelectMany<State, T, U, V>(this State<State, State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class StateTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Task<U>> Select<State, T, U>(this State<State, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Task<T>> Where<State, T>(this State<State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static State<State, Task<V>> SelectMany<State, T, U, V>(this State<State, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, IEnumerable<U>> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, IEnumerable<T>> Where<Env, Out, State, T>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, IEnumerable<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Lst<U>> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Lst<T>> Where<Env, Out, State, T>(this Rws<Env, Out, State, Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Lst<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Map<K, U>> Select<Env, Out, State, T, K, U>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Map<K, T>> Where<Env, Out, State, T, K>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Map<K, V>> SelectMany<Env, Out, State, T, K, U, V>(this Rws<Env, Out, State, Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, TryOption<U>> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, TryOption<T>> Where<Env, Out, State, T>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, TryOption<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Try<U>> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Try<T>> Where<Env, Out, State, T>(this Rws<Env, Out, State, Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Try<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Either<L, U>> Select<Env, Out, State, T, L, U>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Either<L, T>> Where<Env, Out, State, T, L>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Either<L, V>> SelectMany<Env, Out, State, T, L, U, V>(this Rws<Env, Out, State, Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, EitherUnsafe<L, U>> Select<Env, Out, State, T, L, U>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, EitherUnsafe<L, T>> Where<Env, Out, State, T, L>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, EitherUnsafe<L, V>> SelectMany<Env, Out, State, T, L, U, V>(this Rws<Env, Out, State, EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Rws<Env, Out, State, U>> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Rws<Env, Out, State, T>> Where<Env, Out, State, T>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Rws<Env, Out, State, V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class RwsTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Task<U>> Select<Env, Out, State, T, U>(this Rws<Env, Out, State, Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Task<T>> Where<Env, Out, State, T>(this Rws<Env, Out, State, Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Rws<Env, Out, State, Task<V>> SelectMany<Env, Out, State, T, U, V>(this Rws<Env, Out, State, Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<IEnumerable<U>> Select<T, U>(this Task<IEnumerable<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<IEnumerable<T>> Where<T>(this Task<IEnumerable<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<IEnumerable<V>> SelectMany<T, U, V>(this Task<IEnumerable<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Lst<U>> Select<T, U>(this Task<Lst<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Lst<T>> Where<T>(this Task<Lst<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Lst<V>> SelectMany<T, U, V>(this Task<Lst<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Map<K, U>> Select<T, K, U>(this Task<Map<K, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Map<K, T>> Where<T, K>(this Task<Map<K, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Map<K, V>> SelectMany<T, K, U, V>(this Task<Map<K, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<TryOption<U>> Select<T, U>(this Task<TryOption<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<TryOption<T>> Where<T>(this Task<TryOption<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<TryOption<V>> SelectMany<T, U, V>(this Task<TryOption<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Try<U>> Select<T, U>(this Task<Try<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Try<T>> Where<T>(this Task<Try<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Try<V>> SelectMany<T, U, V>(this Task<Try<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Either<L, U>> Select<T, L, U>(this Task<Either<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Either<L, T>> Where<T, L>(this Task<Either<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Either<L, V>> SelectMany<T, L, U, V>(this Task<Either<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<EitherUnsafe<L, U>> Select<T, L, U>(this Task<EitherUnsafe<L, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<EitherUnsafe<L, T>> Where<T, L>(this Task<EitherUnsafe<L, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<EitherUnsafe<L, V>> SelectMany<T, L, U, V>(this Task<EitherUnsafe<L, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Reader<Env, U>> Select<T, Env, U>(this Task<Reader<Env, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Reader<Env, T>> Where<T, Env>(this Task<Reader<Env, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Reader<Env, V>> SelectMany<T, Env, U, V>(this Task<Reader<Env, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Writer<Out, U>> Select<T, Out, U>(this Task<Writer<Out, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Writer<Out, T>> Where<T, Out>(this Task<Writer<Out, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Writer<Out, V>> SelectMany<T, Out, U, V>(this Task<Writer<Out, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<State<State, U>> Select<T, State, U>(this Task<State<State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<State<State, T>> Where<T, State>(this Task<State<State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<State<State, V>> SelectMany<T, State, U, V>(this Task<State<State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Rws<Env, Out, State, U>> Select<T, Env, Out, State, U>(this Task<Rws<Env, Out, State, T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Rws<Env, Out, State, T>> Where<T, Env, Out, State>(this Task<Rws<Env, Out, State, T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Rws<Env, Out, State, V>> SelectMany<T, Env, Out, State, U, V>(this Task<Rws<Env, Out, State, T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    /// <summary>
    /// 
    /// </summary>
    public static partial class TaskTMonadT {
        /// <summary>
        /// Select
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Task<U>> Select<T, U>(this Task<Task<T>> self, Func<T, U> mapper) => self.MapT(x => x.MapT(mapper));
        /// <summary>
        /// Where
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Task<T>> Where<T>(this Task<Task<T>> self, Func<T, bool> pred) => self.MapT(x => x.FilterT(pred));
        /// <summary>
        /// SelectMany
        /// </summary>
        [Pure] [EditorBrowsable(EditorBrowsableState.Never)] public static Task<Task<V>> SelectMany<T, U, V>(this Task<Task<T>> self, Func<T, U> bind, Func<T,U,V> project) => self.MapT(x => x.SelectMany(bind,project));
    }
    }
}

