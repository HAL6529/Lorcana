using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_113_JA_04 : CardInfo
{
    public CardInfo_113_JA_04()
    {
        this.cardNo = "113_JA_04";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ÉãÉ~ÉGÅ[Éã";
        this.cardName2 = "ìîâŒÇÃóF";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.ValentinPalombo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
