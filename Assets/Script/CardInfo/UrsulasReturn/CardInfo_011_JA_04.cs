using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_011_JA_04 : CardInfo
{
    public CardInfo_011_JA_04()
    {
        this.cardNo = "011_JA_04";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "魔法のハープ";
        this.cardName2 = "幸せを運ぶ歌声";
        this.power = 1;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AndreaParisi;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
