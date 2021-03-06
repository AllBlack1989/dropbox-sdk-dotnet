// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Errors for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.RemoveFileMember2Async" />.</para>
    /// </summary>
    public class RemoveFileMemberError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemoveFileMemberError> Encoder = new RemoveFileMemberErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemoveFileMemberError> Decoder = new RemoveFileMemberErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemoveFileMemberError" />
        /// class.</para>
        /// </summary>
        public RemoveFileMemberError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UserError</para>
        /// </summary>
        public bool IsUserError
        {
            get
            {
                return this is UserError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UserError, or <c>null</c>.</para>
        /// </summary>
        public UserError AsUserError
        {
            get
            {
                return this as UserError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccessError</para>
        /// </summary>
        public bool IsAccessError
        {
            get
            {
                return this is AccessError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccessError, or <c>null</c>.</para>
        /// </summary>
        public AccessError AsAccessError
        {
            get
            {
                return this as AccessError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoExplicitAccess</para>
        /// </summary>
        public bool IsNoExplicitAccess
        {
            get
            {
                return this is NoExplicitAccess;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoExplicitAccess, or <c>null</c>.</para>
        /// </summary>
        public NoExplicitAccess AsNoExplicitAccess
        {
            get
            {
                return this as NoExplicitAccess;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RemoveFileMemberError" />.</para>
        /// </summary>
        private class RemoveFileMemberErrorEncoder : enc.StructEncoder<RemoveFileMemberError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemoveFileMemberError value, enc.IJsonWriter writer)
            {
                if (value is UserError)
                {
                    WriteProperty(".tag", "user_error", writer, enc.StringEncoder.Instance);
                    UserError.Encoder.EncodeFields((UserError)value, writer);
                    return;
                }
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is NoExplicitAccess)
                {
                    WriteProperty(".tag", "no_explicit_access", writer, enc.StringEncoder.Instance);
                    NoExplicitAccess.Encoder.EncodeFields((NoExplicitAccess)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RemoveFileMemberError" />.</para>
        /// </summary>
        private class RemoveFileMemberErrorDecoder : enc.UnionDecoder<RemoveFileMemberError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemoveFileMemberError"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemoveFileMemberError Create()
            {
                return new RemoveFileMemberError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override RemoveFileMemberError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "user_error":
                        return UserError.Decoder.DecodeFields(reader);
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "no_explicit_access":
                        return NoExplicitAccess.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The user error object</para>
        /// </summary>
        public sealed class UserError : RemoveFileMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UserError> Encoder = new UserErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UserError> Decoder = new UserErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserError" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public UserError(SharingUserError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UserError" /> class.</para>
            /// </summary>
            private UserError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharingUserError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UserError" />.</para>
            /// </summary>
            private class UserErrorEncoder : enc.StructEncoder<UserError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UserError value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.SharingUserError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UserError" />.</para>
            /// </summary>
            private class UserErrorDecoder : enc.StructDecoder<UserError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UserError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UserError Create()
                {
                    return new UserError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(UserError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "user_error":
                            value.Value = global::Dropbox.Api.Sharing.SharingUserError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : RemoveFileMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccessError> Encoder = new AccessErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccessError> Decoder = new AccessErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AccessError(SharingFileAccessError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            private AccessError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharingFileAccessError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorEncoder : enc.StructEncoder<AccessError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccessError value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.SharingFileAccessError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorDecoder : enc.StructDecoder<AccessError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccessError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccessError Create()
                {
                    return new AccessError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AccessError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "access_error":
                            value.Value = global::Dropbox.Api.Sharing.SharingFileAccessError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>This member does not have explicit access to the file and therefore cannot be
        /// removed. The return value is the access that a user might have to the file from a
        /// parent folder.</para>
        /// </summary>
        public sealed class NoExplicitAccess : RemoveFileMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoExplicitAccess> Encoder = new NoExplicitAccessEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoExplicitAccess> Decoder = new NoExplicitAccessDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoExplicitAccess" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public NoExplicitAccess(MemberAccessLevelResult value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoExplicitAccess" />
            /// class.</para>
            /// </summary>
            private NoExplicitAccess()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public MemberAccessLevelResult Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoExplicitAccess" />.</para>
            /// </summary>
            private class NoExplicitAccessEncoder : enc.StructEncoder<NoExplicitAccess>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoExplicitAccess value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.MemberAccessLevelResult.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoExplicitAccess" />.</para>
            /// </summary>
            private class NoExplicitAccessDecoder : enc.StructDecoder<NoExplicitAccess>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoExplicitAccess" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoExplicitAccess Create()
                {
                    return new NoExplicitAccess();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override NoExplicitAccess DecodeFields(enc.IJsonReader reader)
                {
                    return new NoExplicitAccess(global::Dropbox.Api.Sharing.MemberAccessLevelResult.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : RemoveFileMemberError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return new Other();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Other DecodeFields(enc.IJsonReader reader)
                {
                    return Other.Instance;
                }
            }

            #endregion
        }
    }
}
