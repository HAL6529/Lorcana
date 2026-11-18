using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_126_JA_08 : CardInfo
{
    public CardInfo_126_JA_08()
    {
        this.cardNo = "126_JA_08";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ドードー鳥";
        this.cardName2 = "堂々たる語り部";
        this.power = 0;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FilipeLaurentino;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
