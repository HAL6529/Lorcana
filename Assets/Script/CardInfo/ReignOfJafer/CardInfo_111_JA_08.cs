using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_111_JA_08 : CardInfo
{
    public CardInfo_111_JA_08()
    {
        this.cardNo = "111_JA_08";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ハニー・レモン";
        this.cardName2 = "コスチューム・カタリスト";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AdamFord;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BigHero6;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
