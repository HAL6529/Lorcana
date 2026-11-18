using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_075_JA_08 : CardInfo
{
    public CardInfo_075_JA_08()
    {
        this.cardNo = "075_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "カミロ・マドリガル";
        this.cardName2 = "センターステージ";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarlosGomesCabral;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Madrigal };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Encanto;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
