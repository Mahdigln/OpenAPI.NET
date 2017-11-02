﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// ------------------------------------------------------------

using System.Collections.Generic;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Writers;

namespace Microsoft.OpenApi.Models
{
    /// <summary>
    /// Schema Object.
    /// </summary>
    public class OpenApiSchema : OpenApiElement, IOpenApiReference, IOpenApiExtension
    {
        /// <summary>
        /// Follow JSON Schema definition. Short text providing information about the data.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Value MUST be a string. Multiple types via an array are not supported.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// While relying on JSON Schema's defined formats, 
        /// the OAS offers a few additional predefined formats.
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// CommonMark syntax MAY be used for rich text representation.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public bool ExclusiveMaximum { get; set; } = false;

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public decimal? Minimum { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public bool ExclusiveMinimum { get; set; } = false;

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public int? MaxLength { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public int? MinLength { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// This string SHOULD be a valid regular expression, according to the ECMA 262 regular expression dialect
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public decimal MultipleOf { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// The default value represents what would be assumed by the consumer of the input as the value of the schema if one is not provided.
        /// Unlike JSON Schema, the value MUST conform to the defined type for the Schema Object defined at the same level.
        /// For example, if type is string, then default can be "foo" but cannot be 1.
        /// </summary>
        public IOpenApiAny Default { get; set; }

        /// <summary>
        /// Relevant only for Schema "properties" definitions. Declares the property as "read only".
        /// This means that it MAY be sent as part of a response but SHOULD NOT be sent as part of the request.
        /// If the property is marked as readOnly being true and is in the required list,
        /// the required will take effect on the response only.
        /// A property MUST NOT be marked as both readOnly and writeOnly being true.
        /// Default value is false.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Relevant only for Schema "properties" definitions. Declares the property as "write only".
        /// Therefore, it MAY be sent as part of a request but SHOULD NOT be sent as part of the response. 
        /// If the property is marked as writeOnly being true and is in the required list, 
        /// the required will take effect on the request only.
        /// A property MUST NOT be marked as both readOnly and writeOnly being true. 
        /// Default value is false.
        /// </summary>
        public bool WriteOnly { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Inline or referenced schema MUST be of a Schema Object and not a standard JSON Schema.
        /// </summary>
        public IList<OpenApiSchema> AllOf { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Inline or referenced schema MUST be of a Schema Object and not a standard JSON Schema.
        /// </summary>
        public IList<OpenApiSchema> OneOf { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Inline or referenced schema MUST be of a Schema Object and not a standard JSON Schema.
        /// </summary>
        public IList<OpenApiSchema> AnyOf { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Inline or referenced schema MUST be of a Schema Object and not a standard JSON Schema.
        /// </summary>
        public OpenApiSchema Not { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public IList<string> Required { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Value MUST be an object and not an array. Inline or referenced schema MUST be of a Schema Object 
        /// and not a standard JSON Schema. items MUST be present if the type is array.
        /// </summary>
        public OpenApiSchema Items { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public int? MaxItems { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public int? MinItems { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public bool UniqueItems { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Property definitions MUST be a Schema Object and not a standard JSON Schema (inline or referenced).
        /// </summary>
        public IDictionary<string, OpenApiSchema> Properties { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public int? MaxProperties { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public int? MinProperties { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// Value can be boolean or object. Inline or referenced schema 
        /// MUST be of a Schema Object and not a standard JSON Schema.
        /// </summary>
        public OpenApiSchema AdditionalProperties { get; set; }

        /// <summary>
        /// Adds support for polymorphism. The discriminator is an object name that is used to differentiate 
        /// between other schemas which may satisfy the payload description. 
        /// </summary>
        public OpenApiDiscriminator Discriminator { get; set; }

        /// <summary>
        /// A free-form property to include an example of an instance for this schema. 
        /// To represent examples that cannot be naturally represented in JSON or YAML, 
        /// a string value can be used to contain the example with escaping where necessary.
        /// </summary>
        public IOpenApiAny Example { get; set; }

        /// <summary>
        /// Follow JSON Schema definition: https://tools.ietf.org/html/draft-fge-json-schema-validation-00
        /// </summary>
        public IList<IOpenApiAny> Enum { get; set; } = new List<IOpenApiAny>();

        /// <summary>
        /// Allows sending a null value for the defined schema. Default value is false.
        /// </summary>
        public bool Nullable { get; set; }

        /// <summary>
        /// Additional external documentation for this schema.
        /// </summary>
        public OpenApiExternalDocs ExternalDocs { get; set; }

        /// <summary>
        /// Specifies that a schema is deprecated and SHOULD be transitioned out of usage. 
        /// Default value is false.
        /// </summary>
        public bool Deprecated { get; set; }

        /// <summary>
        /// This MAY be used only on properties schemas. It has no effect on root schemas. 
        /// Adds additional metadata to describe the XML representation of this property.
        /// </summary>
        public OpenApiXml Xml { get; set; }

        /// <summary>
        /// This object MAY be extended with Specification Extensions.
        /// </summary>
        public IDictionary<string, IOpenApiAny> Extensions { get; set; }

        /// <summary>
        /// Reference object.
        /// </summary>
        public OpenApiReference Pointer { get; set; }

        /// <summary>
        /// Serialize <see cref="OpenApiSchema"/> to Open Api v3.0
        /// </summary>
        internal override void WriteAsV3(IOpenApiWriter writer)
        {
            if (writer == null)
            {
                throw Error.ArgumentNull(nameof(writer));
            }

            if (this.IsReference())
            {
                this.WriteRef(writer);
                return;
            }

            writer.WriteStartObject();

            // title
            writer.WriteStringProperty(OpenApiConstants.Title, Title);

            // multipleOf
            writer.WriteNumberProperty(OpenApiConstants.MultipleOf, MultipleOf);

            // maximum
            writer.WriteNumberProperty(OpenApiConstants.Maximum, Maximum);

            // exclusiveMaximum
            writer.WriteBoolProperty(OpenApiConstants.ExclusiveMaximum, ExclusiveMaximum, false);

            // minimum
            writer.WriteNumberProperty(OpenApiConstants.Minimum, Minimum);

            // exclusiveMinimum
            writer.WriteBoolProperty(OpenApiConstants.ExclusiveMinimum, ExclusiveMinimum, false);

            // maxLength
            writer.WriteNumberProperty(OpenApiConstants.MaxLength, MaxLength);

            // minLength
            writer.WriteNumberProperty(OpenApiConstants.MinLength, MinLength);

            // pattern
            writer.WriteStringProperty(OpenApiConstants.Pattern, Pattern);

            // maxItems
            writer.WriteNumberProperty(OpenApiConstants.MaxItems, MaxItems);

            // minItems
            writer.WriteNumberProperty(OpenApiConstants.MinItems, MinItems);

            // uniqueItems
            writer.WriteBoolProperty(OpenApiConstants.UniqueItems, UniqueItems);

            // maxProperties
            writer.WriteNumberProperty(OpenApiConstants.MaxProperties, MaxProperties);

            // minProperties
            writer.WriteNumberProperty(OpenApiConstants.MinProperties, MinProperties);

            // required
            writer.WriteList(OpenApiConstants.Required, Required, (w, s) => w.WriteValue(s));

            // enum
            writer.WriteList(OpenApiConstants.Enum, Enum, (nodeWriter, s) => nodeWriter.WriteAny(s));

            // type
            writer.WriteStringProperty(OpenApiConstants.Type, Type);

            // allOf
            writer.WriteOptionalCollection(OpenApiConstants.AllOf, AllOf, (w, s) => s.WriteAsV3(w));

            // anyOf
            writer.WriteOptionalCollection(OpenApiConstants.AnyOf, AnyOf, (w, s) => s.WriteAsV3(w));

            // oneOf
            writer.WriteOptionalCollection(OpenApiConstants.OneOf, OneOf, (w, s) => s.WriteAsV3(w));

            // not
            writer.WriteOptionalObject(OpenApiConstants.Not, Not, (w, s) => s.WriteAsV3(w));

            // items
            writer.WriteObject(OpenApiConstants.Items, Items, (w, s) => s.WriteAsV3(w));

            // properties
            writer.WriteOptionalMap(OpenApiConstants.Properties, Properties, (w, s) => s.WriteAsV3(w));

            // additionalProperties
            writer.WriteObject(OpenApiConstants.AdditionalProperties, AdditionalProperties, (w, s) => s.WriteAsV3(w));

            // description
            writer.WriteStringProperty(OpenApiConstants.Description, Description);

            // format
            writer.WriteStringProperty(OpenApiConstants.Format, Format);

            // default
            writer.WriteAnyProperty(OpenApiConstants.Default, Default);

            // readOnly
            writer.WriteBoolProperty(OpenApiConstants.Nullable, Nullable);

            // discriminator
            writer.WriteOptionalObject(OpenApiConstants.Discriminator, Discriminator, (w, s) => s.WriteAsV3(w));

            // readOnly
            writer.WriteBoolProperty(OpenApiConstants.ReadOnly, ReadOnly);

            // writeOnly
            writer.WriteBoolProperty(OpenApiConstants.WriteOnly, WriteOnly);

            // xml
            writer.WriteOptionalObject(OpenApiConstants.Xml, Xml, (w, s) => s.WriteAsV2(w));

            // externalDocs
            writer.WriteOptionalObject(OpenApiConstants.ExternalDocs, ExternalDocs, (w, s) => s.WriteAsV3(w));

            // example
            writer.WriteAnyProperty(OpenApiConstants.Example, Example);

            // deprecated
            writer.WriteBoolProperty(OpenApiConstants.Deprecated, Deprecated);

            // extensions
            writer.WriteExtensions(Extensions);

            writer.WriteEndObject();
        }

        /// <summary>
        /// Serialize <see cref="OpenApiSchema"/> to Open Api v2.0
        /// </summary>
        internal override void WriteAsV2(IOpenApiWriter writer)
        {
            if (writer == null)
            {
                throw Error.ArgumentNull(nameof(writer));
            }

            if (this.IsReference())
            {
                this.WriteRef(writer);
                return;
            }

            writer.WriteStartObject();
            WriteAsSchemaProperties(writer);
            writer.WriteEndObject();
        }

        internal void WriteAsItemsProperties(IOpenApiWriter writer)
        {
            if (writer == null)
            {
                throw Error.ArgumentNull(nameof(writer));
            }

            // type
            writer.WriteStringProperty(OpenApiConstants.Type, Type);

            // format
            writer.WriteStringProperty(OpenApiConstants.Format, Format);

            // items
            writer.WriteObject(OpenApiConstants.Items, Items, (w, s) => s.WriteAsV2(w));

            // collectionFormat
            // We need information from style in parameter to populate this.
            // The best effort we can make is to pull this information from the first parameter
            // that leverages this schema. However, that in itself may not be as simple
            // as the schema directly under parameter might be referencing one in the Components,
            // so we will need to do a full scan of the object before we can write the value for
            // this property. This is not supported yet, so we will skip this property at the moment.

            // default
            writer.WriteAnyProperty(OpenApiConstants.Default, Default);

            // maximum
            writer.WriteNumberProperty(OpenApiConstants.Maximum, Maximum);

            // exclusiveMaximum
            writer.WriteBoolProperty(OpenApiConstants.ExclusiveMaximum, ExclusiveMaximum, false);

            // minimum
            writer.WriteNumberProperty(OpenApiConstants.Minimum, Minimum);

            // exclusiveMinimum
            writer.WriteBoolProperty(OpenApiConstants.ExclusiveMinimum, ExclusiveMinimum, false);

            // maxLength
            writer.WriteNumberProperty(OpenApiConstants.MaxLength, MaxLength);

            // minLength
            writer.WriteNumberProperty(OpenApiConstants.MinLength, MinLength);

            // pattern
            writer.WriteStringProperty(OpenApiConstants.Pattern, Pattern);

            // maxItems
            writer.WriteNumberProperty(OpenApiConstants.MaxItems, MaxItems);

            // minItems
            writer.WriteNumberProperty(OpenApiConstants.MinItems, MinItems);

            // enum
            writer.WriteList(OpenApiConstants.Enum, Enum, (w, s) => w.WriteAny(s));

            // multipleOf
            writer.WriteNumberProperty(OpenApiConstants.MultipleOf, MultipleOf);

            // extensions
            writer.WriteExtensions(Extensions);
        }

        internal void WriteAsSchemaProperties(IOpenApiWriter writer)
        {
            if (writer == null)
            {
                throw Error.ArgumentNull(nameof(writer));
            }

            // format
            writer.WriteStringProperty(OpenApiConstants.Format, Format);

            // title
            writer.WriteStringProperty(OpenApiConstants.Title, Title);

            // description
            writer.WriteStringProperty(OpenApiConstants.Description, Description);

            // default
            writer.WriteAnyProperty(OpenApiConstants.Default, Default);

            // multipleOf
            writer.WriteNumberProperty(OpenApiConstants.MultipleOf, MultipleOf);

            // maximum
            writer.WriteNumberProperty(OpenApiConstants.Maximum, Maximum);

            // exclusiveMaximum
            writer.WriteBoolProperty(OpenApiConstants.ExclusiveMaximum, ExclusiveMaximum, false);

            // minimum
            writer.WriteNumberProperty(OpenApiConstants.Minimum, Minimum);

            // exclusiveMinimum
            writer.WriteBoolProperty(OpenApiConstants.ExclusiveMinimum, ExclusiveMinimum, false);

            // maxLength
            writer.WriteNumberProperty(OpenApiConstants.MaxLength, MaxLength);

            // minLength
            writer.WriteNumberProperty(OpenApiConstants.MinLength, MinLength);

            // pattern
            writer.WriteStringProperty(OpenApiConstants.Pattern, Pattern);

            // maxItems
            writer.WriteNumberProperty(OpenApiConstants.MaxItems, MaxItems);

            // minItems
            writer.WriteNumberProperty(OpenApiConstants.MinItems, MinItems);

            // uniqueItems
            writer.WriteBoolProperty(OpenApiConstants.UniqueItems, UniqueItems);

            // maxProperties
            writer.WriteNumberProperty(OpenApiConstants.MaxProperties, MaxProperties);

            // minProperties
            writer.WriteNumberProperty(OpenApiConstants.MinProperties, MinProperties);

            // required
            writer.WriteList(OpenApiConstants.Required, Required, (w, s) => w.WriteValue(s));

            // enum
            writer.WriteList(OpenApiConstants.Enum, Enum, (w, s) => w.WriteAny(s));

            // type
            writer.WriteStringProperty(OpenApiConstants.Type, Type);

            // items
            writer.WriteObject(OpenApiConstants.Items, Items, (w, s) => s.WriteAsV2(w));

            // allOf
            writer.WriteOptionalCollection(OpenApiConstants.AllOf, AllOf, (w, s) => s.WriteAsV2(w));

            // properties
            writer.WriteOptionalMap(OpenApiConstants.Properties, Properties, (w, s) => s.WriteAsV2(w));

            // additionalProperties
            writer.WriteObject(OpenApiConstants.AdditionalProperties, AdditionalProperties, (w, s) => s.WriteAsV2(w));

            // discriminator
            writer.WriteStringProperty(OpenApiConstants.Discriminator, Discriminator?.PropertyName);

            // readOnly
            writer.WriteBoolProperty(OpenApiConstants.ReadOnly, ReadOnly);

            // xml
            writer.WriteOptionalObject(OpenApiConstants.Xml, Xml, (w, s) => s.WriteAsV2(w));

            // externalDocs
            writer.WriteOptionalObject(OpenApiConstants.ExternalDocs, ExternalDocs, (w, s) => s.WriteAsV2(w));

            // example
            writer.WriteAnyProperty(OpenApiConstants.Example, Example);

            // extensions
            writer.WriteExtensions(Extensions);
        }
    }
}