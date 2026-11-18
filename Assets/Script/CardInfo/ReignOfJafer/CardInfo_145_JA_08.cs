using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_145_JA_08 : CardInfo
{
    public CardInfo_145_JA_08()
    {
        this.cardNo = "145_JA_08";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ファリーン";
        this.cardName2 = "遊びざかりの小鹿";
        this.power = 2;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.Bambi;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
