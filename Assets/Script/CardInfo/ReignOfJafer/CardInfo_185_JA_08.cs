using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_185_JA_08 : CardInfo
{
    public CardInfo_185_JA_08()
    {
        this.cardNo = "185_JA_08";
        this.inkCost = 1;
        this.availableInk = false;
        this.cardName1 = "ダンプトラック";
        this.cardName2 = "カルナージの二等航海士";
        this.power = 0;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AdamFenton;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Pirate};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
