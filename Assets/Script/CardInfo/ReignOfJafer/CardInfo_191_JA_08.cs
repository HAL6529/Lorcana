using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_08 : CardInfo
{
    public CardInfo_191_JA_08()
    {
        this.cardNo = "191_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "アリアナ";
        this.cardName2 = "コロナ王国の王妃";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CarminePucci;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
