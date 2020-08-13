package main

import (
	"formula/pkg/formula"
	"os"
)

func main() {
	input1 := os.Getenv("USERNAME")
	input2 := os.Getenv("EMAIL")

	formula.Formula{
		Username: input1,
		Email:    input2,
	}.Run(os.Stdout)
}
