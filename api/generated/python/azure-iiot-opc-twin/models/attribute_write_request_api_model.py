# coding=utf-8
# --------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License. See License.txt in the project root for
# license information.
#
# Code generated by Microsoft (R) AutoRest Code Generator 2.3.33.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class AttributeWriteRequestApiModel(Model):
    """Attribute and value to write to it.

    :param node_id: Node to write to (mandatory)
    :type node_id: str
    :param attribute: Possible values include: 'NodeClass', 'BrowseName',
     'DisplayName', 'Description', 'WriteMask', 'UserWriteMask', 'IsAbstract',
     'Symmetric', 'InverseName', 'ContainsNoLoops', 'EventNotifier', 'Value',
     'DataType', 'ValueRank', 'ArrayDimensions', 'AccessLevel',
     'UserAccessLevel', 'MinimumSamplingInterval', 'Historizing', 'Executable',
     'UserExecutable', 'DataTypeDefinition', 'RolePermissions',
     'UserRolePermissions', 'AccessRestrictions'
    :type attribute: str or ~azure-iiot-opc-twin.models.NodeAttribute
    :param value: Value to write (mandatory)
    :type value: object
    """

    _validation = {
        'node_id': {'required': True},
        'attribute': {'required': True},
        'value': {'required': True},
    }

    _attribute_map = {
        'node_id': {'key': 'nodeId', 'type': 'str'},
        'attribute': {'key': 'attribute', 'type': 'NodeAttribute'},
        'value': {'key': 'value', 'type': 'object'},
    }

    def __init__(self, node_id, attribute, value):
        super(AttributeWriteRequestApiModel, self).__init__()
        self.node_id = node_id
        self.attribute = attribute
        self.value = value
