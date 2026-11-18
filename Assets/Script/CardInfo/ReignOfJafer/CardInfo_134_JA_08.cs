using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_134_JA_08 : CardInfo
{
    public CardInfo_134_JA_08()
    {
        this.cardNo = "134_JA_08";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "とんすけ";
        this.cardName2 = "やんちゃなウサギ";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.OggyChristiansson;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
