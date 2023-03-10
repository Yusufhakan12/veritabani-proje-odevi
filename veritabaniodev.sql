PGDMP     	    :                z            veritabaniodev    15.0    15.0 Z    ?           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            ?           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            ?           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            ?           1262    16416    veritabaniodev    DATABASE     ?   CREATE DATABASE veritabaniodev WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_Turkey.1254';
    DROP DATABASE veritabaniodev;
                postgres    false            ?            1255    24732    doktorsil()    FUNCTION     r  CREATE FUNCTION public.doktorsil() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	declare
	sil integer;
 begin
 	sil:=(select silinenkod from doktorsilinen order by id desc limit 1);
	delete from doktoriletisimbilgileri where doktoriletisimbilgileri.doktorkod=sil;
	delete from doktorkisiselbilgiler where doktorkisiselbilgiler.doktorkod=sil;
 	return new;
 	end;
	$$;
 "   DROP FUNCTION public.doktorsil();
       public          postgres    false            ?            1255    24728    doktorsilinentablo(integer) 	   PROCEDURE     ?   CREATE PROCEDURE public.doktorsilinentablo(IN p2 integer)
    LANGUAGE sql
    AS $$
insert into doktorsilinen (id,silinenkod) values(1+(select id from doktorsilinen order by id desc limit 1),p2);
$$;
 9   DROP PROCEDURE public.doktorsilinentablo(IN p2 integer);
       public          postgres    false            ?            1255    24730 
   hastasil()    FUNCTION     V  CREATE FUNCTION public.hastasil() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	declare
	sil integer;
 begin
 	sil:=(select silinenkod from hastasilinen order by id desc limit 1);
	delete from iletisimbilgileri where iletisimbilgileri.hastakod=sil;
	delete from kisiselbilgiler where kisiselbilgiler.hastakod=sil;
 	return new;
 	end;
	$$;
 !   DROP FUNCTION public.hastasil();
       public          postgres    false            ?            1255    24687    hastasilinentablo(integer) 	   PROCEDURE     ?   CREATE PROCEDURE public.hastasilinentablo(IN p2 integer)
    LANGUAGE sql
    AS $$
insert into hastasilinen (id,silinenkod) values(1+(select id from hastasilinen order by id desc limit 1),p2);
$$;
 8   DROP PROCEDURE public.hastasilinentablo(IN p2 integer);
       public          postgres    false            ?            1255    24740    personelsil()    FUNCTION     ?  CREATE FUNCTION public.personelsil() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
	declare
	sil integer;
 begin
	sil:=(select silinenkod from personelsilinen order by id desc limit 1);
	delete from personeliletisimbilgileri where personeliletisimbilgileri.personelkod=sil;
	delete from personelkisiselbilgileri where personelkisiselbilgileri.personelkod=sil;
 	return new;
 	end;
	$$;
 $   DROP FUNCTION public.personelsil();
       public          postgres    false            ?            1255    24742    personelsilinentablo(integer) 	   PROCEDURE     ?   CREATE PROCEDURE public.personelsilinentablo(IN p2 integer)
    LANGUAGE sql
    AS $$
insert into personelsilinen (id,silinenkod) values(1+(select id from personelsilinen order by id desc limit 1),p2);
$$;
 ;   DROP PROCEDURE public.personelsilinentablo(IN p2 integer);
       public          postgres    false            ?            1255    25047    sigortakontrol(integer)    FUNCTION     g  CREATE FUNCTION public.sigortakontrol(kod integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
    Declare
    sigortadurumu character varying(20);
    a int;
    begin
    sigortadurumu=(select sigorta From kisiselbilgiler where hastakod=kod);
    if sigortadurumu='Sigortalı' then
    a=100;
    else
    a=0;
    end if;
    return a;
    end;
    $$;
 2   DROP FUNCTION public.sigortakontrol(kod integer);
       public          postgres    false            ?            1259    24865    calisan    TABLE     ?   CREATE TABLE public.calisan (
    kisikod integer NOT NULL,
    adi character varying(40) NOT NULL,
    soyadi character varying(40) NOT NULL,
    calisanturu character varying(20) NOT NULL
);
    DROP TABLE public.calisan;
       public         heap    postgres    false            ?            1259    24864    calisan_kisikod_seq    SEQUENCE     ?   CREATE SEQUENCE public.calisan_kisikod_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 *   DROP SEQUENCE public.calisan_kisikod_seq;
       public          postgres    false    229            ?           0    0    calisan_kisikod_seq    SEQUENCE OWNED BY     K   ALTER SEQUENCE public.calisan_kisikod_seq OWNED BY public.calisan.kisikod;
          public          postgres    false    228            ?            1259    24972    doktorbilgileri    TABLE     ?   CREATE TABLE public.doktorbilgileri (
    kisikod integer NOT NULL,
    doktorkod integer NOT NULL,
    doktorunvan character varying(20)
);
 #   DROP TABLE public.doktorbilgileri;
       public         heap    postgres    false            ?            1259    16507    doktoriletisimbilgileri    TABLE     ?   CREATE TABLE public.doktoriletisimbilgileri (
    doktorkod integer NOT NULL,
    adres character varying(100),
    telefon character varying(11),
    mail character varying(30),
    il character varying(20)
);
 +   DROP TABLE public.doktoriletisimbilgileri;
       public         heap    postgres    false            ?            1259    16502    doktorkisiselbilgiler    TABLE     D  CREATE TABLE public.doktorkisiselbilgiler (
    doktorkod integer NOT NULL,
    kimlikno character varying(11),
    cinsiyet character varying(5),
    anneadi character varying(20),
    babaadi character varying(20),
    medeni character varying(6),
    dogumyeri character varying(20),
    dogumtarihi character varying
);
 )   DROP TABLE public.doktorkisiselbilgiler;
       public         heap    postgres    false            ?            1259    24723    doktorsilinen    TABLE     `   CREATE TABLE public.doktorsilinen (
    id integer NOT NULL,
    silinenkod integer NOT NULL
);
 !   DROP TABLE public.doktorsilinen;
       public         heap    postgres    false            ?            1259    16448    hastabilgileri    TABLE     ?   CREATE TABLE public.hastabilgileri (
    hastakod integer NOT NULL,
    kimlikno character varying(11),
    ad character varying(20),
    soyad character varying(15),
    tahlilkod integer,
    recetead character varying(20)
);
 "   DROP TABLE public.hastabilgileri;
       public         heap    postgres    false            ?            1259    24673    hastasilinen    TABLE     _   CREATE TABLE public.hastasilinen (
    id integer NOT NULL,
    silinenkod integer NOT NULL
);
     DROP TABLE public.hastasilinen;
       public         heap    postgres    false            ?            1259    16489    ilac    TABLE     ^   CREATE TABLE public.ilac (
    ilackod integer NOT NULL,
    ilacadi character varying(20)
);
    DROP TABLE public.ilac;
       public         heap    postgres    false            ?            1259    16453    iletisimbilgileri    TABLE     ?   CREATE TABLE public.iletisimbilgileri (
    hastakod integer NOT NULL,
    adres character varying(100),
    telefon character varying(10),
    mail character varying(30),
    il character varying(20)
);
 %   DROP TABLE public.iletisimbilgileri;
       public         heap    postgres    false            ?            1259    16464    kisiselbilgiler    TABLE     <  CREATE TABLE public.kisiselbilgiler (
    hastakod integer NOT NULL,
    cinsiyet character varying(5),
    anneadi character varying(20),
    babaadi character varying(20),
    medeni character varying(5),
    dogumyeri character varying(20),
    sigorta character varying(10),
    dogumtarihi character varying
);
 #   DROP TABLE public.kisiselbilgiler;
       public         heap    postgres    false            ?            1259    24871    personelbilgileri    TABLE     j   CREATE TABLE public.personelbilgileri (
    kisikod integer NOT NULL,
    personelkod integer NOT NULL
);
 %   DROP TABLE public.personelbilgileri;
       public         heap    postgres    false            ?            1259    16517    personeliletisimbilgileri    TABLE     ?   CREATE TABLE public.personeliletisimbilgileri (
    personelkod integer NOT NULL,
    adres character varying(100),
    telefon character varying(11),
    mail character varying(30),
    il character varying(20)
);
 -   DROP TABLE public.personeliletisimbilgileri;
       public         heap    postgres    false            ?            1259    16522    personelkisiselbilgileri    TABLE     E  CREATE TABLE public.personelkisiselbilgileri (
    personelkod integer NOT NULL,
    cinsiyet character varying(6),
    anneadi character varying(30),
    babaadi character varying(30),
    medeni character(7),
    dogumyeri character varying(20),
    kimlikno character varying(11),
    dogumtarihi character varying(30)
);
 ,   DROP TABLE public.personelkisiselbilgileri;
       public         heap    postgres    false            ?            1259    24734    personelsilinen    TABLE     b   CREATE TABLE public.personelsilinen (
    id integer NOT NULL,
    silinenkod integer NOT NULL
);
 #   DROP TABLE public.personelsilinen;
       public         heap    postgres    false            ?            1259    16479 
   polikinlik    TABLE     s   CREATE TABLE public.polikinlik (
    polikinlikkod integer NOT NULL,
    bolumad character varying(25) NOT NULL
);
    DROP TABLE public.polikinlik;
       public         heap    postgres    false            ?            1259    24998    randevubilgisi    TABLE     ?   CREATE TABLE public.randevubilgisi (
    hastakod integer NOT NULL,
    tarih character varying(30),
    doktorkod integer NOT NULL,
    polikinlikkod integer NOT NULL
);
 "   DROP TABLE public.randevubilgisi;
       public         heap    postgres    false            ?            1259    16484    recete    TABLE     ?   CREATE TABLE public.recete (
    hastakod integer NOT NULL,
    ilacadet integer,
    kullanim character varying(100),
    tarih character varying(40),
    ilackod integer,
    recetead character varying(20)
);
    DROP TABLE public.recete;
       public         heap    postgres    false            ?            1259    16469 	   tahliller    TABLE     f   CREATE TABLE public.tahliller (
    tahlilkod integer NOT NULL,
    tahlilad character varying(30)
);
    DROP TABLE public.tahliller;
       public         heap    postgres    false            ?           2604    24868    calisan kisikod    DEFAULT     r   ALTER TABLE ONLY public.calisan ALTER COLUMN kisikod SET DEFAULT nextval('public.calisan_kisikod_seq'::regclass);
 >   ALTER TABLE public.calisan ALTER COLUMN kisikod DROP DEFAULT;
       public          postgres    false    228    229    229            ?          0    24865    calisan 
   TABLE DATA           D   COPY public.calisan (kisikod, adi, soyadi, calisanturu) FROM stdin;
    public          postgres    false    229   Qr       ?          0    24972    doktorbilgileri 
   TABLE DATA           J   COPY public.doktorbilgileri (kisikod, doktorkod, doktorunvan) FROM stdin;
    public          postgres    false    231   s       ?          0    16507    doktoriletisimbilgileri 
   TABLE DATA           V   COPY public.doktoriletisimbilgileri (doktorkod, adres, telefon, mail, il) FROM stdin;
    public          postgres    false    222   Ss                 0    16502    doktorkisiselbilgiler 
   TABLE DATA           ?   COPY public.doktorkisiselbilgiler (doktorkod, kimlikno, cinsiyet, anneadi, babaadi, medeni, dogumyeri, dogumtarihi) FROM stdin;
    public          postgres    false    221   ?s       ?          0    24723    doktorsilinen 
   TABLE DATA           7   COPY public.doktorsilinen (id, silinenkod) FROM stdin;
    public          postgres    false    226   ?t       x          0    16448    hastabilgileri 
   TABLE DATA           \   COPY public.hastabilgileri (hastakod, kimlikno, ad, soyad, tahlilkod, recetead) FROM stdin;
    public          postgres    false    214   /u       ?          0    24673    hastasilinen 
   TABLE DATA           6   COPY public.hastasilinen (id, silinenkod) FROM stdin;
    public          postgres    false    225   ?u       ~          0    16489    ilac 
   TABLE DATA           0   COPY public.ilac (ilackod, ilacadi) FROM stdin;
    public          postgres    false    220   ?u       y          0    16453    iletisimbilgileri 
   TABLE DATA           O   COPY public.iletisimbilgileri (hastakod, adres, telefon, mail, il) FROM stdin;
    public          postgres    false    215   ?v       z          0    16464    kisiselbilgiler 
   TABLE DATA           x   COPY public.kisiselbilgiler (hastakod, cinsiyet, anneadi, babaadi, medeni, dogumyeri, sigorta, dogumtarihi) FROM stdin;
    public          postgres    false    216   :w       ?          0    24871    personelbilgileri 
   TABLE DATA           A   COPY public.personelbilgileri (kisikod, personelkod) FROM stdin;
    public          postgres    false    230   x       ?          0    16517    personeliletisimbilgileri 
   TABLE DATA           Z   COPY public.personeliletisimbilgileri (personelkod, adres, telefon, mail, il) FROM stdin;
    public          postgres    false    223   Hx       ?          0    16522    personelkisiselbilgileri 
   TABLE DATA           ?   COPY public.personelkisiselbilgileri (personelkod, cinsiyet, anneadi, babaadi, medeni, dogumyeri, kimlikno, dogumtarihi) FROM stdin;
    public          postgres    false    224   ?x       ?          0    24734    personelsilinen 
   TABLE DATA           9   COPY public.personelsilinen (id, silinenkod) FROM stdin;
    public          postgres    false    227   ry       |          0    16479 
   polikinlik 
   TABLE DATA           <   COPY public.polikinlik (polikinlikkod, bolumad) FROM stdin;
    public          postgres    false    218   ?y       ?          0    24998    randevubilgisi 
   TABLE DATA           S   COPY public.randevubilgisi (hastakod, tarih, doktorkod, polikinlikkod) FROM stdin;
    public          postgres    false    232   2z       }          0    16484    recete 
   TABLE DATA           X   COPY public.recete (hastakod, ilacadet, kullanim, tarih, ilackod, recetead) FROM stdin;
    public          postgres    false    219   ?z       {          0    16469 	   tahliller 
   TABLE DATA           8   COPY public.tahliller (tahlilkod, tahlilad) FROM stdin;
    public          postgres    false    217   ?z       ?           0    0    calisan_kisikod_seq    SEQUENCE SET     B   SELECT pg_catalog.setval('public.calisan_kisikod_seq', 18, true);
          public          postgres    false    228            ?           2606    24976 $   doktorbilgileri doktorbilgileri_pkey 
   CONSTRAINT     r   ALTER TABLE ONLY public.doktorbilgileri
    ADD CONSTRAINT doktorbilgileri_pkey PRIMARY KEY (kisikod, doktorkod);
 N   ALTER TABLE ONLY public.doktorbilgileri DROP CONSTRAINT doktorbilgileri_pkey;
       public            postgres    false    231    231            ?           2606    16511 4   doktoriletisimbilgileri doktoriletisimbilgileri_pkey 
   CONSTRAINT     y   ALTER TABLE ONLY public.doktoriletisimbilgileri
    ADD CONSTRAINT doktoriletisimbilgileri_pkey PRIMARY KEY (doktorkod);
 ^   ALTER TABLE ONLY public.doktoriletisimbilgileri DROP CONSTRAINT doktoriletisimbilgileri_pkey;
       public            postgres    false    222            ?           2606    16506 0   doktorkisiselbilgiler doktorkisiselbilgiler_pkey 
   CONSTRAINT     u   ALTER TABLE ONLY public.doktorkisiselbilgiler
    ADD CONSTRAINT doktorkisiselbilgiler_pkey PRIMARY KEY (doktorkod);
 Z   ALTER TABLE ONLY public.doktorkisiselbilgiler DROP CONSTRAINT doktorkisiselbilgiler_pkey;
       public            postgres    false    221            ?           2606    24727     doktorsilinen doktorsilinen_pkey 
   CONSTRAINT     ^   ALTER TABLE ONLY public.doktorsilinen
    ADD CONSTRAINT doktorsilinen_pkey PRIMARY KEY (id);
 J   ALTER TABLE ONLY public.doktorsilinen DROP CONSTRAINT doktorsilinen_pkey;
       public            postgres    false    226            ?           2606    16452 "   hastabilgileri hastabilgileri_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public.hastabilgileri
    ADD CONSTRAINT hastabilgileri_pkey PRIMARY KEY (hastakod);
 L   ALTER TABLE ONLY public.hastabilgileri DROP CONSTRAINT hastabilgileri_pkey;
       public            postgres    false    214            ?           2606    24677    hastasilinen hastasilinen_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.hastasilinen
    ADD CONSTRAINT hastasilinen_pkey PRIMARY KEY (id);
 H   ALTER TABLE ONLY public.hastasilinen DROP CONSTRAINT hastasilinen_pkey;
       public            postgres    false    225            ?           2606    16493    ilac ilac_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.ilac
    ADD CONSTRAINT ilac_pkey PRIMARY KEY (ilackod);
 8   ALTER TABLE ONLY public.ilac DROP CONSTRAINT ilac_pkey;
       public            postgres    false    220            ?           2606    16457 (   iletisimbilgileri iletisimbilgileri_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.iletisimbilgileri
    ADD CONSTRAINT iletisimbilgileri_pkey PRIMARY KEY (hastakod);
 R   ALTER TABLE ONLY public.iletisimbilgileri DROP CONSTRAINT iletisimbilgileri_pkey;
       public            postgres    false    215            ?           2606    16468 $   kisiselbilgiler kisiselbilgiler_pkey 
   CONSTRAINT     h   ALTER TABLE ONLY public.kisiselbilgiler
    ADD CONSTRAINT kisiselbilgiler_pkey PRIMARY KEY (hastakod);
 N   ALTER TABLE ONLY public.kisiselbilgiler DROP CONSTRAINT kisiselbilgiler_pkey;
       public            postgres    false    216            ?           2606    24870    calisan personelPK 
   CONSTRAINT     W   ALTER TABLE ONLY public.calisan
    ADD CONSTRAINT "personelPK" PRIMARY KEY (kisikod);
 >   ALTER TABLE ONLY public.calisan DROP CONSTRAINT "personelPK";
       public            postgres    false    229            ?           2606    24875 (   personelbilgileri personelbilgileri_pkey 
   CONSTRAINT     k   ALTER TABLE ONLY public.personelbilgileri
    ADD CONSTRAINT personelbilgileri_pkey PRIMARY KEY (kisikod);
 R   ALTER TABLE ONLY public.personelbilgileri DROP CONSTRAINT personelbilgileri_pkey;
       public            postgres    false    230            ?           2606    16521 8   personeliletisimbilgileri personeliletisimbilgileri_pkey 
   CONSTRAINT        ALTER TABLE ONLY public.personeliletisimbilgileri
    ADD CONSTRAINT personeliletisimbilgileri_pkey PRIMARY KEY (personelkod);
 b   ALTER TABLE ONLY public.personeliletisimbilgileri DROP CONSTRAINT personeliletisimbilgileri_pkey;
       public            postgres    false    223            ?           2606    16526 6   personelkisiselbilgileri personelkisiselbilgileri_pkey 
   CONSTRAINT     }   ALTER TABLE ONLY public.personelkisiselbilgileri
    ADD CONSTRAINT personelkisiselbilgileri_pkey PRIMARY KEY (personelkod);
 `   ALTER TABLE ONLY public.personelkisiselbilgileri DROP CONSTRAINT personelkisiselbilgileri_pkey;
       public            postgres    false    224            ?           2606    24738 $   personelsilinen personelsilinen_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.personelsilinen
    ADD CONSTRAINT personelsilinen_pkey PRIMARY KEY (id);
 N   ALTER TABLE ONLY public.personelsilinen DROP CONSTRAINT personelsilinen_pkey;
       public            postgres    false    227            ?           2606    16483    polikinlik polikinlik_pkey 
   CONSTRAINT     c   ALTER TABLE ONLY public.polikinlik
    ADD CONSTRAINT polikinlik_pkey PRIMARY KEY (polikinlikkod);
 D   ALTER TABLE ONLY public.polikinlik DROP CONSTRAINT polikinlik_pkey;
       public            postgres    false    218            ?           2606    25002 "   randevubilgisi randevubilgisi_pkey 
   CONSTRAINT     ?   ALTER TABLE ONLY public.randevubilgisi
    ADD CONSTRAINT randevubilgisi_pkey PRIMARY KEY (hastakod, doktorkod, polikinlikkod);
 L   ALTER TABLE ONLY public.randevubilgisi DROP CONSTRAINT randevubilgisi_pkey;
       public            postgres    false    232    232    232            ?           2606    16488    recete recete_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.recete
    ADD CONSTRAINT recete_pkey PRIMARY KEY (hastakod);
 <   ALTER TABLE ONLY public.recete DROP CONSTRAINT recete_pkey;
       public            postgres    false    219            ?           2606    16473    tahliller tahliller_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.tahliller
    ADD CONSTRAINT tahliller_pkey PRIMARY KEY (tahlilkod);
 B   ALTER TABLE ONLY public.tahliller DROP CONSTRAINT tahliller_pkey;
       public            postgres    false    217            ?           1259    25008    fki_d    INDEX     D   CREATE INDEX fki_d ON public.randevubilgisi USING btree (hastakod);
    DROP INDEX public.fki_d;
       public            postgres    false    232            ?           1259    24993    fki_doktorkisiselbilgiler    INDEX     Z   CREATE INDEX fki_doktorkisiselbilgiler ON public.doktorbilgileri USING btree (doktorkod);
 -   DROP INDEX public.fki_doktorkisiselbilgiler;
       public            postgres    false    231            ?           1259    24987    fki_i    INDEX     F   CREATE INDEX fki_i ON public.doktorbilgileri USING btree (doktorkod);
    DROP INDEX public.fki_i;
       public            postgres    false    231            ?           1259    24789    fki_ilackod    INDEX     A   CREATE INDEX fki_ilackod ON public.recete USING btree (ilackod);
    DROP INDEX public.fki_ilackod;
       public            postgres    false    219            ?           1259    16463    fki_iletisimbilgileri    INDEX     T   CREATE INDEX fki_iletisimbilgileri ON public.hastabilgileri USING btree (hastakod);
 )   DROP INDEX public.fki_iletisimbilgileri;
       public            postgres    false    214            ?           1259    24693    fki_kisiselbilgiler    INDEX     R   CREATE INDEX fki_kisiselbilgiler ON public.hastabilgileri USING btree (hastakod);
 '   DROP INDEX public.fki_kisiselbilgiler;
       public            postgres    false    214            ?           1259    24661    fki_kisiselbilgileri    INDEX     S   CREATE INDEX fki_kisiselbilgileri ON public.hastabilgileri USING btree (hastakod);
 (   DROP INDEX public.fki_kisiselbilgileri;
       public            postgres    false    214            ?           1259    25014    fki_polikinlik    INDEX     R   CREATE INDEX fki_polikinlik ON public.randevubilgisi USING btree (polikinlikkod);
 "   DROP INDEX public.fki_polikinlik;
       public            postgres    false    232            ?           1259    24754 
   fki_recete    INDEX     I   CREATE INDEX fki_recete ON public.hastabilgileri USING btree (hastakod);
    DROP INDEX public.fki_recete;
       public            postgres    false    214            ?           1259    24760    fki_tahlilkod    INDEX     M   CREATE INDEX fki_tahlilkod ON public.hastabilgileri USING btree (tahlilkod);
 !   DROP INDEX public.fki_tahlilkod;
       public            postgres    false    214            ?           2620    24904 !   personelbilgileri personelsiltrig    TRIGGER     |   CREATE TRIGGER personelsiltrig AFTER DELETE ON public.personelbilgileri FOR EACH ROW EXECUTE FUNCTION public.personelsil();
 :   DROP TRIGGER personelsiltrig ON public.personelbilgileri;
       public          postgres    false    230    237            ?           2606    24881 "   personelbilgileri PersonelPersonel    FK CONSTRAINT     ?   ALTER TABLE ONLY public.personelbilgileri
    ADD CONSTRAINT "PersonelPersonel" FOREIGN KEY (kisikod) REFERENCES public.calisan(kisikod) ON UPDATE CASCADE ON DELETE CASCADE;
 N   ALTER TABLE ONLY public.personelbilgileri DROP CONSTRAINT "PersonelPersonel";
       public          postgres    false    230    3284    229            ?           2606    24977 &   doktorbilgileri doktorbilgileriCalisan    FK CONSTRAINT     ?   ALTER TABLE ONLY public.doktorbilgileri
    ADD CONSTRAINT "doktorbilgileriCalisan" FOREIGN KEY (kisikod) REFERENCES public.calisan(kisikod) ON UPDATE CASCADE ON DELETE CASCADE;
 R   ALTER TABLE ONLY public.doktorbilgileri DROP CONSTRAINT "doktorbilgileriCalisan";
       public          postgres    false    3284    231    229            ?           2606    24982 )   doktorbilgileri doktoriletisimbilgileriFK    FK CONSTRAINT     ?   ALTER TABLE ONLY public.doktorbilgileri
    ADD CONSTRAINT "doktoriletisimbilgileriFK" FOREIGN KEY (doktorkod) REFERENCES public.doktoriletisimbilgileri(doktorkod) NOT VALID;
 U   ALTER TABLE ONLY public.doktorbilgileri DROP CONSTRAINT "doktoriletisimbilgileriFK";
       public          postgres    false    231    3272    222            ?           2606    24988 %   doktorbilgileri doktorkisiselbilgiler    FK CONSTRAINT     ?   ALTER TABLE ONLY public.doktorbilgileri
    ADD CONSTRAINT doktorkisiselbilgiler FOREIGN KEY (doktorkod) REFERENCES public.doktorkisiselbilgiler(doktorkod) NOT VALID;
 O   ALTER TABLE ONLY public.doktorbilgileri DROP CONSTRAINT doktorkisiselbilgiler;
       public          postgres    false    231    3270    221            ?           2606    25003    randevubilgisi hastabilgileri    FK CONSTRAINT     ?   ALTER TABLE ONLY public.randevubilgisi
    ADD CONSTRAINT hastabilgileri FOREIGN KEY (hastakod) REFERENCES public.hastabilgileri(hastakod) NOT VALID;
 G   ALTER TABLE ONLY public.randevubilgisi DROP CONSTRAINT hastabilgileri;
       public          postgres    false    214    3255    232            ?           2606    24784    recete ilackod    FK CONSTRAINT     {   ALTER TABLE ONLY public.recete
    ADD CONSTRAINT ilackod FOREIGN KEY (ilackod) REFERENCES public.ilac(ilackod) NOT VALID;
 8   ALTER TABLE ONLY public.recete DROP CONSTRAINT ilackod;
       public          postgres    false    219    3268    220            ?           2606    16458     hastabilgileri iletisimbilgileri    FK CONSTRAINT     ?   ALTER TABLE ONLY public.hastabilgileri
    ADD CONSTRAINT iletisimbilgileri FOREIGN KEY (hastakod) REFERENCES public.iletisimbilgileri(hastakod) NOT VALID;
 J   ALTER TABLE ONLY public.hastabilgileri DROP CONSTRAINT iletisimbilgileri;
       public          postgres    false    214    3257    215            ?           2606    24694    hastabilgileri kisiselbilgiler    FK CONSTRAINT     ?   ALTER TABLE ONLY public.hastabilgileri
    ADD CONSTRAINT kisiselbilgiler FOREIGN KEY (hastakod) REFERENCES public.kisiselbilgiler(hastakod) NOT VALID;
 H   ALTER TABLE ONLY public.hastabilgileri DROP CONSTRAINT kisiselbilgiler;
       public          postgres    false    216    3259    214            ?           2606    25009    randevubilgisi polikinlik    FK CONSTRAINT     ?   ALTER TABLE ONLY public.randevubilgisi
    ADD CONSTRAINT polikinlik FOREIGN KEY (polikinlikkod) REFERENCES public.polikinlik(polikinlikkod) NOT VALID;
 C   ALTER TABLE ONLY public.randevubilgisi DROP CONSTRAINT polikinlik;
       public          postgres    false    218    3263    232            ?           2606    24755    hastabilgileri tahlilkod    FK CONSTRAINT     ?   ALTER TABLE ONLY public.hastabilgileri
    ADD CONSTRAINT tahlilkod FOREIGN KEY (tahlilkod) REFERENCES public.tahliller(tahlilkod) NOT VALID;
 B   ALTER TABLE ONLY public.hastabilgileri DROP CONSTRAINT tahlilkod;
       public          postgres    false    217    3261    214            ?   ?   x?E?=?0?g?0???Ȁ?
?X?E?4A	?܂???l-?"Qi+Y?z?-?y'?rI??:??h??y,F1???L!K??K?nSh?G/Ϫ?LڦҁB???F+???lϦ?????~??E??3HY!???CIZ?r!?%?b?Dou}?-a/?2??G`?+F??Q?P?      ?   ;   x?34?4600?t?O?24?9K?r???@<#΀??4.Ccǘ32?H?4F??? ?U?      ?   ?   x?-?=
?0?Y>ENP?Z?[?Bo?EA??d??!?Lΐ?S??`?K4<??CHK??.[????}8>.??????b꡹???ӻZ?8?AY??1q??}?5?y??
\8c?B9D?ki??????z???A???6Rx???yB? [}4?         ?   x???1N?0@??S?T?m???B%+?OmK??vAj.?18Cw??{a?T??ے???J?K6xy8J!%>??q?R_)!????F?
61? ?Ӽm>Y?????;?cI??倵?O??y???j??'???o???l}??3??5mе?5J???H_?
&?|*??*??q<80??Sy?4??rc?
J?6-???'q.?T/??v??y@??!?{g??0_WUU? rFs`      ?   "   x?3?4?2?4604?2R?\& ʄ+F??? B?H      x      x?=?1?0F???a?c?6?@Bbu1R?4С\?3???"b??>=af??Z???:??ext?9??????./????{?O?A?@????V?|?J?>&"p??>9?Ű????>ݨ????#?      ?   '   x?3?4?2?4202?2R\&?D?p?A?=... ??T      ~   ?   x?5?;?0D??S??P?? ???fZ%?Dv\pJ?Bܻ??.??b?f??BF??я????6ɫ?j?a\B|?6C?>/g\?p??AiH?PQ?/8?????B?$?;?AI?N?P????Ui???;?a?????[Nf?"~_?=?      y   ?   x?-?=?0Fg?=A??'܂%?EmR)!C9ܡ?A?=?{z򧥔0??Le?GT???????`??Nk?f?䗍??-????%?q@N|4ڿ?6VG??<:?J?8?4W?)>?rbB?r??_??Xm|?ĭB? ?*2#      z   ?   x?]?=j?0?z|
? ?2?w???6??i?????0V?r??>C?{ev?[h~??x2Zkj8?@u^'K'?H?|_<?:&\2??\Y?e&??Fψ?h]???:?oQl?N??zH?dOO6????9?G<?a?G*U͛D3F?Z?l??3t?Ernp???=׳??a??&?㝆???7?:?N?N?N?#[?v??J??_-?}????(???kB      ?       x?34?4100?24ц\?? ڈ+F??? E>f      ?   k   x?3100?LKI+N?4?0?015?L+NIK?TpL9??2171???? (?Rbiniajf?	TT$??
???A??8S??F?9M,?-???????eV?dr??qqq q? u      ?   ?   x?}???0E??7???? ?JIKs?X???p$
`f?????RѼ????Du?m?0?? ,?o}?????rj?8S??-?	?i@MZ??!????"????ȏa? ?6J?ȴ+?2???MC#~?ү?/i??|??UX???,???W????y??? ??E?      ?      x?3?4?2?4100?2Q?\1z\\\ '65      |   ?   x?3??N,Jɬ??????2?<<??4???ˆ0M8?3s?jR?L9]32s@L3N????<?Ԣ"??9???mP?@CS?l?Sp??2?4?˒ӿ?$? 5%??Ѐ?-?*3[!$5%??7?tO?Ḱ????? ?!1y      ?   J   x?3200?4?Tp,J?9?1[????H! ?????ܤTNccNC.#CN#34U?U?E%?ř U???\1z\\\ ?      }   :   x?3?4?A.#?H!;?(???\??(1???l###?`?ӈ31??Ș+F??? ?9      {   M   x?3?:?-?$=5?ˈ?;1O!$1#'3'?˘?Ȇ???"??	gH~n~zQbZ&?)?o????;?9???;W? γu     