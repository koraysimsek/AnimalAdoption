PGDMP     5    
                |            AnimalAdoption    15.6    15.6 /    6           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            7           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            8           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            9           1262    16398    AnimalAdoption    DATABASE     �   CREATE DATABASE "AnimalAdoption" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Turkish_T�rkiye.1254';
     DROP DATABASE "AnimalAdoption";
                postgres    false                        2615    2200    public    SCHEMA        CREATE SCHEMA public;
    DROP SCHEMA public;
                pg_database_owner    false            :           0    0    SCHEMA public    COMMENT     6   COMMENT ON SCHEMA public IS 'standard public schema';
                   pg_database_owner    false    4            �            1255    32827    AdoptionBackupTrigger()    FUNCTION     �  CREATE FUNCTION public."AdoptionBackupTrigger"() RETURNS trigger
    LANGUAGE plpgsql
    AS $$
BEGIN
    -- Eğer AdoptionBackup tablosu yoksa, oluştur
    IF NOT EXISTS (SELECT 1 FROM information_schema.tables WHERE table_name = 'AdoptionBackup' AND table_schema = 'public') THEN
        CREATE TABLE public."AdoptionBackup" (
            "Id" serial PRIMARY KEY,
            "UserId" int4 NOT NULL,
            "AnimalId" int4 NOT NULL,
            "InsertedAt" timestamp without time zone DEFAULT CURRENT_TIMESTAMP
        );
    END IF;

    -- Yeni kaydı AdoptionBackup tablosuna ekle
    INSERT INTO public."AdoptionBackup" ("UserId", "AnimalId", "InsertedAt")
    VALUES (NEW."UserId", NEW."AnimalId", CURRENT_TIMESTAMP);

    RETURN NEW;
END;
$$;
 0   DROP FUNCTION public."AdoptionBackupTrigger"();
       public          postgres    false    4            �            1259    16440    Animal    TABLE     �  CREATE TABLE public."Animal" (
    "Id" integer NOT NULL,
    "Name" character varying(100) NOT NULL,
    "Age" integer NOT NULL,
    "AnimalSpecies" character varying(100) NOT NULL,
    "AnimalTypeId" integer NOT NULL,
    "Gender" character varying(100) NOT NULL,
    "IsInfertile" boolean NOT NULL,
    "IsVaccinated" boolean NOT NULL,
    "IsAdopted" boolean NOT NULL,
    CONSTRAINT age_check CHECK ((("Age" >= 0) AND ("Age" <= 50)))
);
    DROP TABLE public."Animal";
       public         heap    postgres    false    4            �            1255    32814 r   InsertAnimal(character varying, integer, character varying, integer, character varying, boolean, boolean, boolean)    FUNCTION     d  CREATE FUNCTION public."InsertAnimal"(name character varying, age integer, species character varying, typeid integer, gender character varying, isinfertile boolean, isvaccinated boolean, isadopted boolean) RETURNS public."Animal"
    LANGUAGE plpgsql
    AS $$
DECLARE
    new_animal public."Animal"%ROWTYPE;
BEGIN
    INSERT INTO public."Animal" ("Name", "Age", "AnimalSpecies", "AnimalTypeId", "Gender", "IsInfertile", "IsVaccinated", "IsAdopted")
    VALUES (name, age, species, typeid, gender, isinfertile, isvaccinated, isadopted)
    RETURNING * INTO new_animal;

    RETURN new_animal;
END;
$$;
 �   DROP FUNCTION public."InsertAnimal"(name character varying, age integer, species character varying, typeid integer, gender character varying, isinfertile boolean, isvaccinated boolean, isadopted boolean);
       public          postgres    false    4    221            �            1255    32813 |   InsertAnimal(character varying, integer, character varying, character varying, character varying, boolean, boolean, boolean)    FUNCTION     d  CREATE FUNCTION public."InsertAnimal"(name character varying, age integer, species character varying, typeid character varying, gender character varying, isinfertile boolean, isvaccinated boolean, isadopted boolean) RETURNS public."Animal"
    LANGUAGE plpgsql
    AS $$
DECLARE
    new_animal public."Animal"%ROWTYPE;
BEGIN
    INSERT INTO public."Animal" ("Name", "Age", "AnimalSpecies", "AnimalTypeId", "Gender", "IsInfertile", "IsVaccinated", "IsAdopted")
    VALUES (name, age, species, typeid, gender, isinfertile, isvaccinated, isadopted)
    RETURNING * INTO new_animal;

    RETURN new_animal;
END;
$$;
 �   DROP FUNCTION public."InsertAnimal"(name character varying, age integer, species character varying, typeid character varying, gender character varying, isinfertile boolean, isvaccinated boolean, isadopted boolean);
       public          postgres    false    221    4            �            1259    32783    Adoption    TABLE     ~   CREATE TABLE public."Adoption" (
    "Id" integer NOT NULL,
    "UserId" integer NOT NULL,
    "AnimalId" integer NOT NULL
);
    DROP TABLE public."Adoption";
       public         heap    postgres    false    4            �            1259    32830    AdoptionBackup    TABLE     �   CREATE TABLE public."AdoptionBackup" (
    "Id" integer NOT NULL,
    "UserId" integer NOT NULL,
    "AnimalId" integer NOT NULL,
    "InsertedAt" timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
 $   DROP TABLE public."AdoptionBackup";
       public         heap    postgres    false    4            �            1259    32829    AdoptionBackup_Id_seq    SEQUENCE     �   CREATE SEQUENCE public."AdoptionBackup_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 .   DROP SEQUENCE public."AdoptionBackup_Id_seq";
       public          postgres    false    4    226            ;           0    0    AdoptionBackup_Id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public."AdoptionBackup_Id_seq" OWNED BY public."AdoptionBackup"."Id";
          public          postgres    false    225            �            1259    32782    Adoption_Id_seq    SEQUENCE     �   ALTER TABLE public."Adoption" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Adoption_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    223    4            �            1259    16424 
   AnimalType    TABLE     �   CREATE TABLE public."AnimalType" (
    "Id" integer NOT NULL,
    "Code" character varying NOT NULL,
    "Description" character varying
);
     DROP TABLE public."AnimalType";
       public         heap    postgres    false    4            �            1259    16423    AnimalType_Id_seq    SEQUENCE     �   ALTER TABLE public."AnimalType" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."AnimalType_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    219            �            1259    16439    Animal_Id_seq    SEQUENCE     �   ALTER TABLE public."Animal" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."Animal_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    221            �            1259    16400    User    TABLE     �  CREATE TABLE public."User" (
    "Id" integer NOT NULL,
    "Username" character varying(100) NOT NULL,
    "Password" character varying(100) NOT NULL,
    "Firstname" character varying(100) NOT NULL,
    "Lastname" character varying(100) NOT NULL,
    "BirthDate" date NOT NULL,
    "City" character varying(100),
    "Address" character varying(255),
    "UserTypeId" integer NOT NULL
);
    DROP TABLE public."User";
       public         heap    postgres    false    4            �            1259    32808    CustomerAdoption    VIEW     �  CREATE VIEW public."CustomerAdoption" AS
 SELECT a2."Name",
    a2."Age",
    a2."AnimalSpecies",
    a2."Gender",
    a2."IsInfertile",
    a2."IsVaccinated",
    at2."Code",
    u."Id" AS "UserId"
   FROM (((public."Adoption" a
     JOIN public."User" u ON ((u."Id" = a."UserId")))
     JOIN public."Animal" a2 ON ((a2."Id" = a."AnimalId")))
     JOIN public."AnimalType" at2 ON ((at2."Id" = a2."AnimalTypeId")));
 %   DROP VIEW public."CustomerAdoption";
       public          postgres    false    221    215    219    219    221    221    221    221    221    223    221    221    223    4            �            1259    16408    UserType    TABLE     �   CREATE TABLE public."UserType" (
    "Id" integer NOT NULL,
    "Code" character varying NOT NULL,
    "Description" character varying
);
    DROP TABLE public."UserType";
       public         heap    postgres    false    4            �            1259    16407    UserType_Id_seq    SEQUENCE     �   ALTER TABLE public."UserType" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."UserType_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    217    4            �            1259    16399    User_Id_seq    SEQUENCE     �   ALTER TABLE public."User" ALTER COLUMN "Id" ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."User_Id_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    4    215            �           2604    40977    AdoptionBackup Id    DEFAULT     |   ALTER TABLE ONLY public."AdoptionBackup" ALTER COLUMN "Id" SET DEFAULT nextval('public."AdoptionBackup_Id_seq"'::regclass);
 D   ALTER TABLE public."AdoptionBackup" ALTER COLUMN "Id" DROP DEFAULT;
       public          postgres    false    225    226    226            1          0    32783    Adoption 
   TABLE DATA                 public          postgres    false    223   �>       3          0    32830    AdoptionBackup 
   TABLE DATA                 public          postgres    false    226   ?       /          0    16440    Animal 
   TABLE DATA                 public          postgres    false    221   �?       -          0    16424 
   AnimalType 
   TABLE DATA                 public          postgres    false    219   4A       )          0    16400    User 
   TABLE DATA                 public          postgres    false    215   DB       +          0    16408    UserType 
   TABLE DATA                 public          postgres    false    217   �C       <           0    0    AdoptionBackup_Id_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public."AdoptionBackup_Id_seq"', 3, true);
          public          postgres    false    225            =           0    0    Adoption_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."Adoption_Id_seq"', 8, true);
          public          postgres    false    222            >           0    0    AnimalType_Id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public."AnimalType_Id_seq"', 5, true);
          public          postgres    false    218            ?           0    0    Animal_Id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public."Animal_Id_seq"', 17, true);
          public          postgres    false    220            @           0    0    UserType_Id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public."UserType_Id_seq"', 2, true);
          public          postgres    false    216            A           0    0    User_Id_seq    SEQUENCE SET     <   SELECT pg_catalog.setval('public."User_Id_seq"', 11, true);
          public          postgres    false    214            �           2606    32836 "   AdoptionBackup AdoptionBackup_pkey 
   CONSTRAINT     f   ALTER TABLE ONLY public."AdoptionBackup"
    ADD CONSTRAINT "AdoptionBackup_pkey" PRIMARY KEY ("Id");
 P   ALTER TABLE ONLY public."AdoptionBackup" DROP CONSTRAINT "AdoptionBackup_pkey";
       public            postgres    false    226            �           2606    32787    Adoption adoption_pk 
   CONSTRAINT     V   ALTER TABLE ONLY public."Adoption"
    ADD CONSTRAINT adoption_pk PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public."Adoption" DROP CONSTRAINT adoption_pk;
       public            postgres    false    223            �           2606    16444    Animal animal_pk 
   CONSTRAINT     R   ALTER TABLE ONLY public."Animal"
    ADD CONSTRAINT animal_pk PRIMARY KEY ("Id");
 <   ALTER TABLE ONLY public."Animal" DROP CONSTRAINT animal_pk;
       public            postgres    false    221            �           2606    16430    AnimalType animaltype_pk 
   CONSTRAINT     Z   ALTER TABLE ONLY public."AnimalType"
    ADD CONSTRAINT animaltype_pk PRIMARY KEY ("Id");
 D   ALTER TABLE ONLY public."AnimalType" DROP CONSTRAINT animaltype_pk;
       public            postgres    false    219            �           2606    16406    User user_pk 
   CONSTRAINT     N   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT user_pk PRIMARY KEY ("Id");
 8   ALTER TABLE ONLY public."User" DROP CONSTRAINT user_pk;
       public            postgres    false    215            �           2606    16414    UserType usertype_pk 
   CONSTRAINT     V   ALTER TABLE ONLY public."UserType"
    ADD CONSTRAINT usertype_pk PRIMARY KEY ("Id");
 @   ALTER TABLE ONLY public."UserType" DROP CONSTRAINT usertype_pk;
       public            postgres    false    217            �           2620    32828     Adoption adoption_insert_trigger    TRIGGER     �   CREATE TRIGGER adoption_insert_trigger AFTER INSERT ON public."Adoption" FOR EACH ROW EXECUTE FUNCTION public."AdoptionBackupTrigger"();
 ;   DROP TRIGGER adoption_insert_trigger ON public."Adoption";
       public          postgres    false    223    229            �           2606    32820    Adoption fk_animal    FK CONSTRAINT     �   ALTER TABLE ONLY public."Adoption"
    ADD CONSTRAINT fk_animal FOREIGN KEY ("AnimalId") REFERENCES public."Animal"("Id") ON DELETE CASCADE;
 >   ALTER TABLE ONLY public."Adoption" DROP CONSTRAINT fk_animal;
       public          postgres    false    221    223    3215            �           2606    32798    Animal fk_animaltype    FK CONSTRAINT     �   ALTER TABLE ONLY public."Animal"
    ADD CONSTRAINT fk_animaltype FOREIGN KEY ("AnimalTypeId") REFERENCES public."AnimalType"("Id");
 @   ALTER TABLE ONLY public."Animal" DROP CONSTRAINT fk_animaltype;
       public          postgres    false    221    3213    219            �           2606    32815    Adoption fk_user    FK CONSTRAINT     �   ALTER TABLE ONLY public."Adoption"
    ADD CONSTRAINT fk_user FOREIGN KEY ("UserId") REFERENCES public."User"("Id") ON DELETE CASCADE;
 <   ALTER TABLE ONLY public."Adoption" DROP CONSTRAINT fk_user;
       public          postgres    false    3209    223    215            �           2606    32803    User fk_usertype    FK CONSTRAINT     }   ALTER TABLE ONLY public."User"
    ADD CONSTRAINT fk_usertype FOREIGN KEY ("UserTypeId") REFERENCES public."UserType"("Id");
 <   ALTER TABLE ONLY public."User" DROP CONSTRAINT fk_usertype;
       public          postgres    false    215    217    3211            1   ^   x���v
Q���W((M��L�SrL�/(���SR�s
�t��sW�q�Us�	u���
�:
�:
&��\��c6ǐbs������ ǀ<V      3   �   x��̱�0 Н����	4�k{-u���D�]q!� ��2���񅦭/��;C��qi���g�����c
����-�d6��!�M!5y�^��,�M�?$a�I�I�� )��7N8���S-g�>=����:��g�|��@S      /   i  x����N�@��<ņK5!�
��H��1]$�-N�-f�&֗�ȹ�@y/w�V%x��lv�0����YwBoF��lJޕBp�����I�s��ܾ;�JgΘ̻��8)�����*TH��"����K	���~��/}���/Y��-�H�Mp��p�����{�T��� \� ��<��O�Z��#�׿�S���|G
.�cxQЙ%���:�0�'%
�A�WP��y��*b�a�<\�.���j�#3��]�L���F�FИ}����g�����z�����gztd�g�����Ω�*M�f>��1")��-��[;�k��!Oqi	ͳ��0X�ë�����)� �r�J��5���� ��      -      x��ѽj�0��Oq��B�S'��V�u�v��R_$�F���d̜�S6'�U)	-t�I�w�K�8́%���������y��f�8Mٔ%���gy�
���->�\\�!|Ƃ��-Q��w���	X!n�~%�V��\�������'|����A��<�rG��?�Pև��z�ƁO�Z�x���V�H`u�B��������I���omk��˺�[^R#�R(�Z�t� ��O�E�>����
�oz�e      )   M  x����N�0��y���i�Ⱥ���
�b��!�@Ն�#�#�^��0r�<�l��F�r7�=_�/�~��(p���pV錒y��1o����}��݃`��&��ȩj .�Ж�,P�a�Q�6�;��-.OL�����MSu�ϵ@l�R����^��^޶����]F	+a,��9	�Î.���1m]"�3�G�DA��Xn�U�81�G��~�C��:!K7�nU�L Zx���3���!�J����.����m�!�
�O^�y��6��Qԗ�R^�J���:)�$���c�p�lPc�k�(Ѫ��N-���1=�'9��@�x�/q^��Z_���{      +   r   x���v
Q���W((M��L�S
-N-
�,HUR�s
�t��sW�q�Us�	u���
F:
꾇��_�Z����QH�,�<:?S]Ӛ˓";��:��f��
���� �~=N     