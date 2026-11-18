using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_138_JA_08 : CardInfo
{
    public CardInfo_138_JA_08()
    {
        this.cardNo = "138_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ル・フウ";
        this.cardName2 = "ケーキどろぼう";
        this.power = 2;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.SimoneBuonfantino;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby, EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
