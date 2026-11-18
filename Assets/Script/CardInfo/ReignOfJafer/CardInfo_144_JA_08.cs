using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_144_JA_08 : CardInfo
{
    public CardInfo_144_JA_08()
    {
        this.cardNo = "144_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "フクロウ";
        this.cardName2 = "気むずかしいお隣さん";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.JamesReySanchez;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
