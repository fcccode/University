;������ ��� ��������� �������� �� ASM-80
;�������� ������ ���� � ��������� ��������!

;������� ��������
        org 0800h
	lxi h,mas
	lda kil
	mvi c,0
	mov a,m
	m1: cpi 0
	jm a1
	dcr b
	a1:inr c
	dcr b
	jmp m1
	sta rez
        hlt
	kil: db 5
	mas: db 127,-128,-130,135,-140
	rez: db 0
;ʳ���� ��������
        end

