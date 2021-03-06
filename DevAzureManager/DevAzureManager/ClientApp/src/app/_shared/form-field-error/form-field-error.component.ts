import { Component, OnInit, Input } from '@angular/core';
import { FormControl } from '@angular/forms';

@Component({
  selector: 'app-form-field-error',
  templateUrl: './form-field-error.component.html',
  styleUrls: ['./form-field-error.component.styl']
})
export class FormFieldErrorComponent implements OnInit {
  @Input('form-control') formControl: FormControl;

  constructor() { }

  ngOnInit() {
  }

  public get errorMessage(): string | null {
    if (this.mustShowErrorMessage()) {
      return this.getErrorMessage();
    } else {
      return null;
    }
  }

  private mustShowErrorMessage(): boolean {
    return this.formControl.invalid && this.formControl.touched;
  }

  private getErrorMessage(): string | null {
    if (this.formControl.errors.required) {
      return 'campo obrigatório';
    } else if (this.formControl.errors.hasNumber) {
      return 'deve ter no mínimo um número';
    } else if (this.formControl.errors.hasCapitalCase) {
      return 'deve ter no mínimo uma letra maiúscula';
    } else if (this.formControl.errors.hasSmallCase) {
      return 'deve ter no mínimo uma letra minúscula';
    } else if (this.formControl.errors.hasSpecialCharacters) {
      return 'deve ter no mínimo um caracter especial';
    } else if (this.formControl.errors.minlength) {
      const requiredLength = this.formControl.errors.minlength.requiredLength;
      return `deve ter no mínimo ${requiredLength} caracteres`;
    } else if (this.formControl.errors.maxlength) {
      const requiredLength = this.formControl.errors.maxlength.requiredLength;
      return `deve ter no máximo ${requiredLength} caracteres`;
    } else if (this.formControl.errors.mustMatch) {
      return 'valores incompatíveis.';
    }
  }

}

