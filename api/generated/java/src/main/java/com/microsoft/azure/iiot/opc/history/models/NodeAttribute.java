/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.history.models;

import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;

/**
 * Defines values for NodeAttribute.
 */
public enum NodeAttribute {
    /** Enum value NodeClass. */
    NODE_CLASS("NodeClass"),

    /** Enum value BrowseName. */
    BROWSE_NAME("BrowseName"),

    /** Enum value DisplayName. */
    DISPLAY_NAME("DisplayName"),

    /** Enum value Description. */
    DESCRIPTION("Description"),

    /** Enum value WriteMask. */
    WRITE_MASK("WriteMask"),

    /** Enum value UserWriteMask. */
    USER_WRITE_MASK("UserWriteMask"),

    /** Enum value IsAbstract. */
    IS_ABSTRACT("IsAbstract"),

    /** Enum value Symmetric. */
    SYMMETRIC("Symmetric"),

    /** Enum value InverseName. */
    INVERSE_NAME("InverseName"),

    /** Enum value ContainsNoLoops. */
    CONTAINS_NO_LOOPS("ContainsNoLoops"),

    /** Enum value EventNotifier. */
    EVENT_NOTIFIER("EventNotifier"),

    /** Enum value Value. */
    VALUE("Value"),

    /** Enum value DataType. */
    DATA_TYPE("DataType"),

    /** Enum value ValueRank. */
    VALUE_RANK("ValueRank"),

    /** Enum value ArrayDimensions. */
    ARRAY_DIMENSIONS("ArrayDimensions"),

    /** Enum value AccessLevel. */
    ACCESS_LEVEL("AccessLevel"),

    /** Enum value UserAccessLevel. */
    USER_ACCESS_LEVEL("UserAccessLevel"),

    /** Enum value MinimumSamplingInterval. */
    MINIMUM_SAMPLING_INTERVAL("MinimumSamplingInterval"),

    /** Enum value Historizing. */
    HISTORIZING("Historizing"),

    /** Enum value Executable. */
    EXECUTABLE("Executable"),

    /** Enum value UserExecutable. */
    USER_EXECUTABLE("UserExecutable"),

    /** Enum value DataTypeDefinition. */
    DATA_TYPE_DEFINITION("DataTypeDefinition"),

    /** Enum value RolePermissions. */
    ROLE_PERMISSIONS("RolePermissions"),

    /** Enum value UserRolePermissions. */
    USER_ROLE_PERMISSIONS("UserRolePermissions"),

    /** Enum value AccessRestrictions. */
    ACCESS_RESTRICTIONS("AccessRestrictions");

    /** The actual serialized value for a NodeAttribute instance. */
    private String value;

    NodeAttribute(String value) {
        this.value = value;
    }

    /**
     * Parses a serialized value to a NodeAttribute instance.
     *
     * @param value the serialized value to parse.
     * @return the parsed NodeAttribute object, or null if unable to parse.
     */
    @JsonCreator
    public static NodeAttribute fromString(String value) {
        NodeAttribute[] items = NodeAttribute.values();
        for (NodeAttribute item : items) {
            if (item.toString().equalsIgnoreCase(value)) {
                return item;
            }
        }
        return null;
    }

    @JsonValue
    @Override
    public String toString() {
        return this.value;
    }
}
