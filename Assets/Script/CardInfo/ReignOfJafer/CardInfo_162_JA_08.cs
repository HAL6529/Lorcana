using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_162_JA_08 : CardInfo
{
    public CardInfo_162_JA_08()
    {
        this.cardNo = "162_JA_08";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ジャスミン";
        this.cardName2 = "センスある潜入者";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JosephBuenning;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
