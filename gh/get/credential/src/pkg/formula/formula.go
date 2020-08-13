package formula

import (
	"encoding/json"
	"fmt"
	"io"
)

// Formula adfasfadf
type Formula struct {
	Username string
	Email    string
}

// Run asfaf
func (h Formula) Run(writer io.Writer) {
	v, err := json.Marshal(h)
	if err != nil {
		panic(err)
	}
	writer.Write(v)
	fmt.Println("")

}
