/**
 * Copyright (c) Microsoft Corporation. All rights reserved.
 * Licensed under the MIT License. See License.txt in the project root for
 * license information.
 *
 * Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

package com.microsoft.azure.iiot.opc.twin.models;

import java.util.List;
import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * Result of attribute reads.
 */
public class ReadResponseApiModel {
    /**
     * All results of attribute reads.
     */
    @JsonProperty(value = "results")
    private List<AttributeReadResponseApiModel> results;

    /**
     * Get all results of attribute reads.
     *
     * @return the results value
     */
    public List<AttributeReadResponseApiModel> results() {
        return this.results;
    }

    /**
     * Set all results of attribute reads.
     *
     * @param results the results value to set
     * @return the ReadResponseApiModel object itself.
     */
    public ReadResponseApiModel withResults(List<AttributeReadResponseApiModel> results) {
        this.results = results;
        return this;
    }

}
