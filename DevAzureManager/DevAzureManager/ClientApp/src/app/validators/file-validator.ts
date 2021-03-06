import { AbstractControl, FormGroup, ValidationErrors, ValidatorFn } from '@angular/forms';

export function TypeFileValidator(type: string) {
    const tipoArquivosAceitos = [
        'application/pdf',
        'application/vnd.openxmlformats-officedocument.wordprocessingml.document',
        'application/msword'
    ];
    if (!tipoArquivosAceitos.includes(type)) {
        return true;
    }
    return false;
}

export function SizeFileValidator(size: number) {
    if (size > 3145728) {
        return true;
    }
    return false;
}

export function NoWhitespaceValidator(teste): ValidatorFn {

    return (control: AbstractControl): { [key: string]: any } => {
        console.log(teste);
        const isWhitespace = (control.value || '').trim().length === 0;
        const isValid = !isWhitespace;
        return isValid ? null : { 'whitespace': 'value is only whitespace' };
    };
}
