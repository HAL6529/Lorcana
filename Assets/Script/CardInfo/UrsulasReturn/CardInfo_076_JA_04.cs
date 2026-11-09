using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_076_JA_04 : CardInfo
{
    public CardInfo_076_JA_04()
    {
        this.cardNo = "076_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉwÉâ";
        this.cardName2 = "ê_ÅXÇÃèóâ§";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Queen, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Ward };
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
