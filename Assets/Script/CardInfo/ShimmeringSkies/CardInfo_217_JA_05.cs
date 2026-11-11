using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_217_JA_05 : CardInfo
{
    public CardInfo_217_JA_05()
    {
        this.cardNo = "217_JA_05";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ムファサ";
        this.cardName2 = "プライドロックの統治者";
        this.power = 4;
        this.toughness = 9;
        this.lore = 4;
        this.illustrator = EnumController.Illustrator.JochemVanGool;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ShimmeringSkies;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
