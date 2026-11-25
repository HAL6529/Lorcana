using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_151_JA_13 : CardInfo
{
    public CardInfo_151_JA_13()
    {
        this.cardNo = "151_JA_13";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "アルファ";
        this.cardName2 = "群れのリーダー";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.Up;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
