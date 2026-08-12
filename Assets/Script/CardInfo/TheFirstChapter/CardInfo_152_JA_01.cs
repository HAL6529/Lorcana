using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_152_JA_01 : CardInfo
{
    public CardInfo_152_JA_01()
    {
        this.cardNo = "152_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "ÉÇÅ[ÉäÉX";
        this.cardName2 = "ê¢äEìIÇ»î≠ñæâ∆";
        this.power = 2;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = "Alex Accorsi";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Mentor, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
