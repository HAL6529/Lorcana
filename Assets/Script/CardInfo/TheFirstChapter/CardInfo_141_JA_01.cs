using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_01 : CardInfo
{
    public CardInfo_141_JA_01()
    {
        this.cardNo = "141_JA_01";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "発明エンジニア";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Gabriel Romero";
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
