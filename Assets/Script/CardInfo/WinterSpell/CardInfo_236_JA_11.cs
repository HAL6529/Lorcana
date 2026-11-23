using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_236_JA_11 : CardInfo
{
    public CardInfo_236_JA_11()
    {
        this.cardNo = "236_JA_11";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ベル";
        this.cardName2 = "雪原の戦略家";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JanePica;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
