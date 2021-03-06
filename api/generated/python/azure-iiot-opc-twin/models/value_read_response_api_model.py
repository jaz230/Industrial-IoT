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


class ValueReadResponseApiModel(Model):
    """Value read response model.

    :param value: Value read
    :type value: object
    :param data_type: Built in data type of the value read.
    :type data_type: str
    :param source_picoseconds: Pico seconds part of when value was read at
     source.
    :type source_picoseconds: int
    :param source_timestamp: Timestamp of when value was read at source.
    :type source_timestamp: datetime
    :param server_picoseconds: Pico seconds part of when value was read at
     server.
    :type server_picoseconds: int
    :param server_timestamp: Timestamp of when value was read at server.
    :type server_timestamp: datetime
    :param error_info:
    :type error_info: ~azure-iiot-opc-twin.models.ServiceResultApiModel
    """

    _attribute_map = {
        'value': {'key': 'value', 'type': 'object'},
        'data_type': {'key': 'dataType', 'type': 'str'},
        'source_picoseconds': {'key': 'sourcePicoseconds', 'type': 'int'},
        'source_timestamp': {'key': 'sourceTimestamp', 'type': 'iso-8601'},
        'server_picoseconds': {'key': 'serverPicoseconds', 'type': 'int'},
        'server_timestamp': {'key': 'serverTimestamp', 'type': 'iso-8601'},
        'error_info': {'key': 'errorInfo', 'type': 'ServiceResultApiModel'},
    }

    def __init__(self, value=None, data_type=None, source_picoseconds=None, source_timestamp=None, server_picoseconds=None, server_timestamp=None, error_info=None):
        super(ValueReadResponseApiModel, self).__init__()
        self.value = value
        self.data_type = data_type
        self.source_picoseconds = source_picoseconds
        self.source_timestamp = source_timestamp
        self.server_picoseconds = server_picoseconds
        self.server_timestamp = server_timestamp
        self.error_info = error_info
